/* AUDDATA: Transação responsável por verificar as modificações ocorridas no registro.
 * Faz a função de auditoria de dados.
 * Sua configuração é feita para ser executada, independentemente da tabela a ser utilizada,
 * pois solicita os dados de tabela para execução.
 * Isso só é possível devido a configuração das demais tabelas serem identicas.
*/
using System;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class AUDDATA : Form
    {
        //Variáveis de carga para pesquisa
        public string Empresa { get; private set; }
        public string Codigo { get; private set; }
        public string Tabela { get; private set; }

        public AUDDATA(string Codigo, string Tabela)
        {
            //Constrói o objeto com os dados de código e tabela
            this.Codigo = Codigo;
            this.Tabela = Tabela;
            InitializeComponent();
        }

        public AUDDATA(string Empresa, string Codigo, string Tabela)
        {
            //Constrói o objeto com os dados de empresa, código e tabela, 
            //pois alguns registros terão empresa para separar as entidades.
            this.Empresa = Empresa;
            this.Codigo = Codigo;
            this.Tabela = Tabela;
            InitializeComponent();
        }

        private void AUDDATA_Shown(object sender, EventArgs e)
        {
            //Ao mostrar o objeto, fará a execução da busca na classe NAUDDATA
            try
            {
                NAUDDATA Auditoria = new NAUDDATA(Codigo, Tabela);
                SslMensagem.Text = Auditoria.BuscaMudanca();
                DgAudData.DataSource = Auditoria.DsAudData;
                DgAudData.DataMember = Tabela;
            }
            catch (Exception ex)
            {
                SslMensagem.Text = Codigo + ", " + Tabela + ", " + ex.Message;
            }
        }
    }
}
