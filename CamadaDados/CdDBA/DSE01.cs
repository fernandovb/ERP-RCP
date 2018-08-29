/* DSE01 Módulo para interação entre database e o sistema. Faz o registro das informações
 * no banco de dados, recebendo as informações do módulo NSE01.
*/

using System;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdConexao;


namespace CamadaDados.CdDBA
{
    public class DSE01
    {
        public int Empresa { get; private set; }
        public int Codigo { get; private set; }
        public char Situacao { get; private set; }
        public string Nome { get; private set; }
        public string Federal { get; private set; }
        public double ValorPart { get; private set; }
        public double QuotaPart { get; private set; }

        public DSE01(int Empresa, int Codigo, char Situacao, string Nome, string Federal, double ValorPart, double QuotaPart)
        {
            this.Empresa = Empresa;
            this.Codigo = Codigo;
            this.Situacao = Situacao;
            this.Nome = Nome;
            this.Federal = Federal;
            this.ValorPart = ValorPart;
            this.QuotaPart = QuotaPart;
        }

        public string InserirSocio()
        {
            string mensagem = "";
            try
            {
                Conexao.OpenDatabase();
                MySqlCommand SInserir = new MySqlCommand
                {
                    Connection = Conexao.ERP_Conexao,
                    CommandText = "sp_dba_empresa_socio_inserir"
                };
                SInserir.CommandType = CommandType.StoredProcedure;
                SInserir.Parameters.AddWithValue("codigo", Codigo);
                SInserir.Parameters.AddWithValue("empresa", Empresa);
                SInserir.Parameters.AddWithValue("situacao", Situacao);
                SInserir.Parameters.AddWithValue("nome", Nome);
                SInserir.Parameters.AddWithValue("federal", Federal);
                SInserir.Parameters.AddWithValue("valor_part", ValorPart);
                SInserir.Parameters.AddWithValue("quota_part", QuotaPart);
                if (SInserir.ExecuteNonQuery() == 1)
                    mensagem = "Sócio " + Codigo + " incluso com sucesso.";
                else
                    mensagem = "Erro ao inserir sócio " + Codigo + ". Favor verificar";
            }
            catch (MySqlException ex)
            {
                mensagem = "Não foi possível inserir sócio. " + ex.Message;
            }
            finally
            {
                Conexao.CloseDatabase();
            }
            return mensagem;
        }

        public void AlterarSocio()
        {

        }

        public void ChamarSocio()
        {

        }
    }
}
