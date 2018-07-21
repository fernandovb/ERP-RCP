using System;
using MySql.Data.MySqlClient;

namespace CamadaDados.CdConexao
{
    public static class Conexao
    {
        public static MySqlConnection ERP_Conexao;

        public static string Conectar(string server, string database, string user, string senha)
        {
            string mensagem = "";
            string comando = "Persist Security Info=False;" +
                             "server=" + server + ";" +
                             "database=" + database + ";" +
                             "uid=" + user + ";" +
                             "pwd=" + senha;
            ERP_Conexao = new MySqlConnection(comando);
            try
            {
                ERP_Conexao.Open();
                mensagem = "Conexão bem sucedida!";
                ERP_Conexao.Close();
            }
            catch (Exception ex)
            {
                mensagem = "Erro na conexão: " + ex.Message;
            }
            return mensagem;
        }

        public static string Desconectar()
        {
            string mensagem = "";
            try
            {
                ERP_Conexao.Close();
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
            try
            {
                ERP_Conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CloseDatabase()
        {
            try
            {
                ERP_Conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
