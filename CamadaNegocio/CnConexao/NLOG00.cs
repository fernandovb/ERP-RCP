using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.CdConexao;

namespace CamadaNegocio.CnConexao
{
    public class NLOG00
    {
        public string Servidor { get; private set; }
        public string Database { get; private set; }
        public string User { get; private set; }
        public string Senha { get; private set; }
        public int Empresa { get; private set; }

        public NLOG00(string Servidor, string Database, string User, string Senha, int Empresa)
        {
            this.Servidor = Servidor;
            this.Database = Database;
            this.User = User;
            this.Senha = Senha;
            this.Empresa = Empresa;
        }

        public string AbrirBD()
        {
            return Conexao.Conectar(Servidor, Database, User, Senha, Empresa);
        }

        public string FecharDB()
        {
            return Conexao.Desconectar();
        }

    }
}
