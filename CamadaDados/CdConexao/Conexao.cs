using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CamadaDados.CdConexao
{
    public static class Conexao
    {
        public static MySqlConnection ERP_Conexao;
        public static MySqlConnection LOG_Conexao;

        public static string Conectar(string server, string database, string user, string senha)
        {
            string mensagem = "";
            string comando = "Persist Security Info=False;" +
                             "server=" + server + ";" +
                             "database=" + database + ";" +
                             "uid=" + user + ";" +
                             "pwd=" + senha;
            ERP_Conexao = new MySqlConnection(comando);
            ConectarLogRCP(server, "log_rcp", user, senha);
            try
            {
                OpenDatabase();
                mensagem = "Conexão bem sucedida!";
                CloseDatabase();
            }
            catch (Exception ex)
            {
                mensagem = "Erro na conexão: " + ex.Message;
            }
            return mensagem;
        }

        public static void ConectarLogRCP(string server, string database, string user, string senha)
        {
            string comando = "Persist Security Info=False;" +
                             "server=" + server + ";" +
                             "database=" + database + ";" +
                             "uid=" + user + ";" +
                             "pwd=" + senha;
            LOG_Conexao = new MySqlConnection(comando);
        }

        public static string Desconectar()
        {
            string mensagem = "";
            try
            {
                ERP_Conexao.Close();
                LOG_Conexao.Close();
                mensagem = "BD desconectado.";
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao desconectar: " + ex.Message;
            }
            return mensagem;
        }

        public static bool OpenDatabase()
        {
            if (ERP_Conexao.State == ConnectionState.Closed)
            { 
                ERP_Conexao.Open();
                LOG_Conexao.Open();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CloseDatabase()
        {
            if (ERP_Conexao.State == ConnectionState.Open)
            {
                ERP_Conexao.Close();
                LOG_Conexao.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
