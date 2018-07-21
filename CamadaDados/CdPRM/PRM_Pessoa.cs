using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;

namespace CamadaDados.CdPRM
{
    public class PRM_Pessoa
    {
        public static MySqlDataAdapter MaConsPessoa;
        public string Nome { get; private set; }
        public string NomeAlternativo { get; private set; }
        public string Municipio { get; private set; }

        public PRM_Pessoa(string Nome, string NomeAlternativo, string Municipio)
        {
            this.Nome = Nome;
            this.NomeAlternativo = NomeAlternativo;
            this.Municipio = Municipio;
        }

        public void LocalizarPessoa(DataSet d)
        {
            string comando = "SELECT " +
                "prm_codigo, " +
                "prm_nome_formal as nome, " +
                "prm_nome_alternativo as alternativo, " +
                "prm_cidade as cidade, " +
                "prm_estado as estado, "+
                "prm_federal as federal, "+
                "prm_estadual as estadual, "+
                "prm_municipal as municipal"+
                "FROM prm_pessoa";
            MaConsPessoa = new MySqlDataAdapter(comando, Conexao.ERP_Conexao);
            MaConsPessoa.Fill(d, "prm_pessoa");
        }
    }
}
