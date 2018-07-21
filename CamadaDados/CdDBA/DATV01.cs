using System;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;

namespace CamadaDados.CdDBA
{
    public class DATV01
    {
        public string codigo { get; private set; }
        public string descricao { get; private set; }
        public string observacao { get; private set; }
        public static MySqlDataAdapter MaPesquisa;

        public DATV01(string codigo, string descricao, string observacao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.observacao = observacao;
        }

        public DATV01(string codigo)
        {
            this.codigo = codigo;
        }

        public string InserirAtividade()
        {
            string mensagem = "Erro ao inserir atividade!";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand Inserir = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_atividade_inserir"
                };
                Inserir.CommandType = CommandType.StoredProcedure;
                Inserir.Parameters.AddWithValue("codigo", codigo);
                Inserir.Parameters.AddWithValue("descricao", descricao);
                Inserir.Parameters.AddWithValue("observacao", observacao);
                Inserir.ExecuteNonQuery();
                mensagem = "Registro " + codigo + " incluso com sucesso.";
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível proceder com a inclusão." + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public string AlterarAtividade()
        {
            string mensagem = "Erro ao alterar atividade!";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand Alterar = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_atividade_alterar"
                };
                Alterar.CommandType = CommandType.StoredProcedure;
                Alterar.Parameters.AddWithValue("codigo", codigo);
                Alterar.Parameters.AddWithValue("descricao", descricao);
                Alterar.Parameters.AddWithValue("observacao", observacao);
                Alterar.ExecuteNonQuery();
                mensagem = "Alteração realizada com sucesso.";
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao realizar alteração. " + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
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
                descricao = Carregar.Parameters["descricao"].Value.ToString();
                observacao = Carregar.Parameters["observacao"].Value.ToString();
                mensagem = "Dados carregados.";
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao realizar alteração. " + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public static void LocalizarAtividade(string comando)
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
