/* Classe responsável pela intermediação de ações com "atividades".
 * Responsável por acessar a camada de dados (CamadaDados) para executar ações de
 * inserção, alteração e consulta.
 * As ações de exclusão não são implantadas no sistema devido a auditoria de dados.
 * No seu lugar são feitos bloqueios no cadastro, desativando o acesso.
*/

using System;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;

namespace CamadaDados.CdDBA
{
    public class DATV01
    {
        //Variáveis gerado da classe para utilização nas ações
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public string Observacao { get; private set; }
        public MySqlDataAdapter MaPesquisa;

        /* **********************
         * *****Construtores*****
           ********************** */

        public DATV01(string codigo, string descricao, string observacao)
        {
            //Construtor para inclusão de "atividades", onde traz todos os dados
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Observacao = observacao;
        }

        public DATV01(string codigo)
        {
            //Construtor para alteração e consulta, onde traz somente o código
            this.Codigo = codigo;
        }

        /* *****************
         * *****Métodos*****
           ***************** */ 

        public string InserirAtividade()
        {
            //Método para inclusão de "atividades" novas ao BD

            string mensagem = ""; //Variável para retorno de mensagem
            //Abre a conexão com o banco de dados
            Conexao.OpenDatabase(); //Método chamado da CamadaDados
            try
            {
                MySqlCommand Inserir = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_atividade_inserir"
                };
                //Especifica o tipo de comando a ser executado
                Inserir.CommandType = CommandType.StoredProcedure;
                //Insere os parâmetros ao comando
                Inserir.Parameters.AddWithValue("codigo", Codigo);
                Inserir.Parameters.AddWithValue("descricao", Descricao);
                Inserir.Parameters.AddWithValue("observacao", Observacao);
                //Executa o comando SQL
                if (Inserir.ExecuteNonQuery() == 1) //Verifica se o comando foi executado com sucesso
                    mensagem = "Atividade " + Codigo + " inclusa com sucesso."; //Se sim, retorna mensagem de sucesso
                else
                    mensagem = "Erro ao inserir atividade. Verifique se já existe."; //Se não, retornar mensagem de erro.
            }
            catch (MySqlException ex)
            {
                //Retornar mensagem de erro
                mensagem = "Não foi possível realizar inserção da atividade. " + ex.Message;
            }
            finally
            {
                //Fecha a conexão
                Conexao.CloseDatabase(); //Método chamado da CamadaDados
            }
            return mensagem;
        }

        public string AlterarAtividade()
        {
            //Método para alterar "atividades" existentes no BD
            string mensagem = "Erro ao alterar atividade!"; //Variável para retorno de mensagem
            try
            {
                //Abre a conexão com o bando de dados
                Conexao.OpenDatabase();
                //Cria comando para execução de instruções SQL
                MySqlCommand Alterar = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_atividade_alterar"
                };
                //Especifica o tipo de comando a ser executado
                Alterar.CommandType = CommandType.StoredProcedure;
                //Inclui os parâmetros ao comando
                Alterar.Parameters.AddWithValue("codigo", Codigo);
                Alterar.Parameters.AddWithValue("descricao", Descricao);
                Alterar.Parameters.AddWithValue("observacao", Observacao);
                //Executa o comando
                Alterar.ExecuteNonQuery();
                //Informa que foi tudo bem sucedido
                mensagem = "Alteração realizada com sucesso.";
            }
            catch (MySqlException ex)
            {
                //Retorna mensagem de erro caso tenha ocorrido algum problema
                mensagem = "Erro ao realizar alteração. " + ex.Message;
            }
            finally
            {
                //Fecha o banco de dados
                Conexao.CloseDatabase();
            }
            //Retorna a mensagem do ocorrido
            return mensagem;
        }

        public string CarregaAtividade(string codigo)
        {
            string mensagem = "";
            try
            {
                Conexao.ERP_Conexao.Open();
                MySqlCommand Carregar = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_atividade_chamar"
                };
                Carregar.CommandType = CommandType.StoredProcedure;
                Carregar.Parameters.AddWithValue("codigo", codigo);
                Carregar.Parameters.AddWithValue("descricao", "@descricao");
                Carregar.Parameters.AddWithValue("observacao", "@observacao");
                Carregar.Parameters["codigo"].Direction = ParameterDirection.Input;
                Carregar.Parameters["descricao"].Direction = ParameterDirection.Output;
                Carregar.Parameters["observacao"].Direction = ParameterDirection.Output;
                Carregar.ExecuteReader();
                Descricao = Carregar.Parameters["descricao"].Value.ToString();
                Observacao = Carregar.Parameters["observacao"].Value.ToString();
                if (Descricao != "")
                {
                    mensagem = "Dados carregados.";
                }
                else
                {
                    mensagem = "Erro ao carregar atividade. Verifique se existe."; //Se não, retornar mensagem de erro.
                }
            }
            catch (MySqlException ex)
            {
                mensagem = "Erro ao realizar alteração. " + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public void LocalizarAtividade(string comando)
        {
            try
            {
                Conexao.OpenDatabase();
                DataSet DsLocalizar = new DataSet();
                MaPesquisa = new MySqlDataAdapter(comando, Conexao.ERP_Conexao);
                MaPesquisa.Fill(DsLocalizar, "dba_atividade");
            }
            catch
            {

            }
            finally
            {
                Conexao.CloseDatabase();
            }
        }
    }
}
