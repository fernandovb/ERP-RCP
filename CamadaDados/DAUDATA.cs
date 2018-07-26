/* DAUDATA: Classe responsável pelo acesso aos dados na base LOG_ERP.static
*/
using System;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;


namespace CamadaDados
{
    public class DAUDATA
    {
        public string Comando { get; private set; }
        public string Tabela { get; private set; }
        public MySqlDataAdapter MaAuditoria;

        public DAUDATA(string Comando, string Tabela)
        {
            this.Comando = Comando;
            this.Tabela = Tabela;
        }

        public string BuscaMudanca(string Comando, string Tabela)
        {
            string Mensagem = "";
            try
            {
                //Abre o banco de dados
                Conexao.OpenDatabase();
                //Cria o DataSet para armazenamento dos dados
                DataSet DsLAuditoria = new DataSet();
                //Cria o MySqlAdapter para execução dos comandos SQL
                MaAuditoria = new MySqlDataAdapter(Comando, Conexao.LOG_Conexao);
                //Alimenta o DataSet com dados do MySqlAdapter
                MaAuditoria.Fill(DsLAuditoria, Tabela);
                Mensagem = "Sistema de auditoria conectado";
            }
            catch (Exception ex)
            {
                Mensagem = "Falha ao conectar ao sistema de auditoria: " + ex.Message;
            }
            finally
            {
                //Fecha o banco de dados
                Conexao.CloseDatabase();
            }
            return Mensagem;
        }
    }
}
