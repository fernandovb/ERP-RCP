/* DGPE01 Módulo para interação entre database e o sistema. Faz o registro das informações
 * no banco de dados, recebendo as informações do módulo NGPE01.
*/

using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;

namespace CamadaDados.CdDBA
{
    public class DGPE01
    {
        public int Codigo { get; private set; }
        public string Nome_Formal { get; private set; }
        public string Nome_Alternativo { get; private set; }
        public char Situacao { get; private set; }
        public string Tp_Societario { get; private set; }
        public double Cap_Social { get; private set; }
        public double Quotas { get; private set; }
        public DateTime DtCriacao { get; private set; }
        public DateTime DtEncerramento { get; private set; }
        public string PerFechamento { get; private set; }
        public List<DSE01> LDSocios { get; private set; }
        public MySqlDataAdapter MaPesquisa;
        
        public DGPE01(int Codigo)
        {
            this.Codigo = Codigo;
        }

        public DGPE01(int Codigo,
                      string Nome_Formal,
                      string Nome_Alternativo,
                      char Situacao,
                      string Tp_Societario,
                      double Cap_Social,
                      double Quotas,
                      DateTime DtCriacao,
                      DateTime DtEncerramento,
                      string PerFechamento,
                      List<DSE01> LDSocios)
        {
            this.Codigo = Codigo;
            this.Nome_Formal = Nome_Formal;
            this.Nome_Alternativo = Nome_Alternativo;
            this.Situacao = Situacao;
            this.Tp_Societario = Tp_Societario;
            this.Cap_Social = Cap_Social;
            this.Quotas = Quotas;
            this.DtCriacao = DtCriacao;
            this.DtEncerramento = DtEncerramento;
            this.PerFechamento = PerFechamento;
            this.LDSocios = LDSocios;
        }

        public string InserirEmpresa()
        {
            string mensagem = "";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand Inserir = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_empresa_inserir"
                };
                Inserir.CommandType = CommandType.StoredProcedure;
                Inserir.Parameters.AddWithValue("codigo", Codigo);
                Inserir.Parameters.AddWithValue("nome_formal", Nome_Formal);
                Inserir.Parameters.AddWithValue("nome_alternativo", Nome_Alternativo);
                Inserir.Parameters.AddWithValue("situacao", Situacao);
                Inserir.Parameters.AddWithValue("tp_societario", Tp_Societario);
                Inserir.Parameters.AddWithValue("cap_social", Cap_Social);
                Inserir.Parameters.AddWithValue("quotas", Quotas);
                Inserir.Parameters.AddWithValue("dcriacao", DtCriacao);
                Inserir.Parameters.AddWithValue("dencerramento", DtEncerramento);
                Inserir.Parameters.AddWithValue("per_fechamento", PerFechamento);
                if (Inserir.ExecuteNonQuery() == 1)
                    mensagem = "Empresa " + Codigo + " inclusa com sucesso.";
                else
                    mensagem = "Erro ao inserir empresa. Verifique se já existe.";
            }
            catch (MySqlException ex)
            {
                mensagem = "Não foi possível realizar inserção da atividade. " + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public string AlterarEmpresa()
        {
            string mensagem = "";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand Alterar = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_empresa_alterar"
                };
                Alterar.CommandType = CommandType.StoredProcedure;
                Alterar.Parameters.AddWithValue("codigo", Codigo);
                Alterar.Parameters.AddWithValue("nome_formal", Nome_Formal);
                Alterar.Parameters.AddWithValue("nome_alternativo", Nome_Alternativo);
                Alterar.Parameters.AddWithValue("situacao", Situacao);
                Alterar.Parameters.AddWithValue("tp_societario", Tp_Societario);
                Alterar.Parameters.AddWithValue("cap_social", Cap_Social);
                Alterar.Parameters.AddWithValue("quotas", Quotas);
                Alterar.Parameters.AddWithValue("dcriacao", DtCriacao);
                Alterar.Parameters.AddWithValue("dencerramento", DtEncerramento);
                Alterar.Parameters.AddWithValue("per_fechamento", PerFechamento);
                Alterar.ExecuteNonQuery();
                mensagem = "Alteração realizada com sucesso.";
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

        public string CarregarEmpresa()
        {
            string mensagem = "";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand Carregar = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_empresa_chamar"
                };
                Carregar.CommandType = CommandType.StoredProcedure;
                Carregar.Parameters.AddWithValue("codigo", Codigo);
                Carregar.Parameters.AddWithValue("nome_formal", Nome_Formal);
                Carregar.Parameters.AddWithValue("nome_alternativo", Nome_Alternativo);
                Carregar.Parameters.AddWithValue("situacao", Situacao);
                Carregar.Parameters.AddWithValue("tp_societario", Tp_Societario);
                Carregar.Parameters.AddWithValue("cap_social", Cap_Social);
                Carregar.Parameters.AddWithValue("quotas", Quotas);
                Carregar.Parameters.AddWithValue("dcriacao", DtCriacao);
                Carregar.Parameters.AddWithValue("dencerramento", DtEncerramento);
                Carregar.Parameters.AddWithValue("per_fechamento", PerFechamento);
                Carregar.Parameters["codigo"].Direction = ParameterDirection.Input;
                Carregar.Parameters["nome_formal"].Direction = ParameterDirection.Output;
                Carregar.Parameters["nome_alternativo"].Direction = ParameterDirection.Output;
                Carregar.Parameters["situacao"].Direction = ParameterDirection.Output;
                Carregar.Parameters["tp_societario"].Direction = ParameterDirection.Output;
                Carregar.Parameters["cap_social"].Direction = ParameterDirection.Output;
                Carregar.Parameters["quotas"].Direction = ParameterDirection.Output;
                Carregar.Parameters["dcriacao"].Direction = ParameterDirection.Output;
                Carregar.Parameters["dencerramento"].Direction = ParameterDirection.Output;
                Carregar.Parameters["per_fechamento"].Direction = ParameterDirection.Output;
                Carregar.ExecuteReader();
                Nome_Formal = Carregar.Parameters["nome_formal"].Value.ToString();
                Nome_Alternativo = Carregar.Parameters["nome_alternativo"].Value.ToString();
                Situacao = char.Parse(Carregar.Parameters["situacao"].Value.ToString());
                Tp_Societario = Carregar.Parameters["tp_societario"].Value.ToString();
                Cap_Social = double.Parse(Carregar.Parameters["cap_social"].Value.ToString());
                Quotas = double.Parse(Carregar.Parameters["quotas"].Value.ToString());
                DtCriacao = DateTime.Parse(Carregar.Parameters["dcriacao"].Value.ToString());
                DtEncerramento = DateTime.Parse(Carregar.Parameters["dencerramento"].Value.ToString());
                PerFechamento = Carregar.Parameters["per_fechamento"].Value.ToString();
                if (Nome_Formal != "")
                    mensagem = "Dados carregados.";
                else
                    mensagem = "Erro ao carregar empresa. Verifique se existe.";
            }
            catch (MySqlException ex)
            {
                mensagem = "Erro ao carregar empresa:" + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public void LocalizarEmpresa(string comando)
        {
            try
            {
                Conexao.OpenDatabase();
                DataSet DsLocalizar = new DataSet();
                MaPesquisa = new MySqlDataAdapter(comando, Conexao.ERP_Conexao);
                MaPesquisa.Fill(DsLocalizar, "dba_empresa");
            }
            finally
            {
                Conexao.CloseDatabase();
            }
        }

        public void TpSocietario()
        {
            try
            {
                Conexao.OpenDatabase();
                DataSet DsSociedade = new DataSet();
                MaPesquisa = new MySqlDataAdapter("SELECT tps_sigla FROM sys_tp_societario", Conexao.ERP_Conexao);
                MaPesquisa.Fill(DsSociedade, "sys_tp_societario");
                string[] Relacao = new string[5];
            }
            finally
            {
                Conexao.CloseDatabase();
            }
        }
    }
}