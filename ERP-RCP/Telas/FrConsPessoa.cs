using System;
using System.Windows.Forms;
using CamadaDados.CdPRM;

namespace ERP_RCP.Telas
{
    public partial class FrConsPessoa : Form
    {
        public FrConsPessoa()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtConfirma_Click(object sender, EventArgs e)
        {
            ClRetorno.CodPessoa = DgResultado.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void BtPesquisas_Click(object sender, EventArgs e)
        {
            PRM_Pessoa c = new PRM_Pessoa(TbNome.Text, TbNomeAltern.Text, TbMunicipio.Text);
            try
            {
                c.LocalizarPessoa(this.DsConsPessoa);
                DgResultado.DataSource = DsConsPessoa;
                DgResultado.DataMember = "prm_pessoa";
                BtConfirma.Enabled = true;
            }
            catch (Exception ex)
            {
                SslMensagem.Text = ex.Message;
            }
        }
    }
}
