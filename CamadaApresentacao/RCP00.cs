using System;
using System.Reflection;
using System.Windows.Forms;
using CamadaDados.CdConexao;

namespace CamadaApresentacao
{
    public partial class RCP00 : Form
    {
        public string user;
        public int empresa;

        public RCP00(string user, int empresa)
        {
            this.user = user;
            this.empresa = empresa;
            InitializeComponent();
        }

        private void FrMenu_Shown(object sender, EventArgs e)
        {
            SslUser.Text = user;
            SslEmpresa.Text = empresa.ToString();
        }

        private void ChamaForm(string formulario)
        {
            var vForm = Application.OpenForms[formulario];
            if (vForm == null)
            {
                try
                {
                    //Type t = Assembly.GetExecutingAssembly().GetType("ERP_RCP.Telas." + formulario);
                    Type t = Assembly.GetExecutingAssembly().GetType("CamadaApresentacao." + formulario);
                    Form f = (Form)Activator.CreateInstance(t);
                    f.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Erro ao chamar o formulário '" + formulario + "'. Favor verificar.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncerrarSistema();
        }

        private void EncerrarSistema()
        {
            Conexao.Desconectar();
            Application.Exit();
        }

        private void FrMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncerrarSistema();
        }

        private void StbComando_Leave(object sender, EventArgs e)
        {
            ChamaForm(StbComando.Text.ToUpper());
            StbComando.Text = "";
        }

        private void TvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode eNode = e.Node;
            string Transacao = Convert.ToString(eNode.Tag);
            if (Transacao != "")
            {
                ChamaForm(Transacao);
            }
        }
    }
}
