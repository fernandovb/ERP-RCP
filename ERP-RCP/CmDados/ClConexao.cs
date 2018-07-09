using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ERP_RCP.CmDados
{
    class ClConexao
    {
        public static MySqlConnection DbConexao;
        public string server { get; private set; }
        public string database { get; private set; }
        public string user { get; private set; }
        public string senha { get; private set; }

        public ClConexao(string server, string database, string user, string senha)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.senha = senha;
        }

        public void ConectaDB()
        {
            string comando = "Persist Security Info=False;" +
                             "server=" + server + ";" +
                             "database=" + database + ";" +
                             "uid=" + user + ";" +
                             "pwd=" + senha;

            DbConexao = new MySqlConnection(comando);
            DbConexao.Open();
        }

        public void DesconectaDB()
        {
            if (DbConexao.State == ConnectionState.Open)
            {
                DbConexao.Close();
            }
        }

    }
}
