using System;
using System.Windows.Forms;
using CamadaNegocio.CnConexao;

namespace CamadaApresentacao
{
    public partial class LOG00 : Form
    {
        public string usuario;
        public int empresa;

        public LOG00()
        {
            InitializeComponent();
        }

        private void TbServer_Leave(object sender, EventArgs e)
        {
            if (TbServer.Text != "" & 
                TbDatabase.Text != "" &
                TbUser.Text != "" &
                TbSenha.Text != "" &
                TbEmpresa.Text != "")
            {
                BtLogin.Enabled = true;
                BtLogin.Focus();
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            NLOG00 cn = new NLOG00(TbServer.Text, TbDatabase.Text, TbUser.Text, TbSenha.Text);
            LbMensagem.Text = cn.AbrirBD();
            if (LbMensagem.Text == "Conexão bem sucedida!")
            {
                this.DialogResult = DialogResult.OK;
                this.usuario = TbUser.Text;
                this.empresa = Convert.ToInt32(TbEmpresa.Text);
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
