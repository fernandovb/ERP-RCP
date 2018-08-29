using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CamadaDados.CdConexao
{
    public static class Conexao
    {
        public static MySqlConnection ERP_Conexao;
        public static MySqlConnection LOG_Conexao;

        public static string Conectar(string server, string database, string user, string senha, int empresa)
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
                bool v = ValidarEmpresa(empresa) == true;
                if (v)
                    mensagem = "Conexão bem sucedida!";
                else
                    mensagem = "Empresa não indentificada. Verifique se o código está correto.";
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

        static bool ValidarEmpresa(int Codigo)
        {
            string Empresa = "";
            try
            {
                MySqlCommand McValida = new MySqlCommand
                {
                    Connection = ERP_Conexao,
                    CommandText = "sp_dba_empresa_validar"
                };
                McValida.CommandType = CommandType.StoredProcedure;
                McValida.Parameters.AddWithValue("codigo", Codigo);
                McValida.Parameters.AddWithValue("empresa", "@empresa");
                McValida.Parameters["empresa"].Direction = ParameterDirection.Output;
                McValida.ExecuteReader();
                Empresa = McValida.Parameters["empresa"].Value.ToString();
                if (int.Parse(Empresa) == Codigo)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
