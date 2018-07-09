using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ERP_RCP.CmDados;

namespace ERP_RCP.Telas
{
    public partial class FrLogin : Form
    {
        public string usuario;
        public int empresa;

        public FrLogin()
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
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            Program.conexao = new ClConexao(TbServer.Text, TbDatabase.Text, TbUser.Text, TbSenha.Text);
            try
            {
                Program.conexao.ConectaDB();
                this.DialogResult = DialogResult.OK;
                this.usuario = TbUser.Text;
                this.empresa = Convert.ToInt32(TbEmpresa.Text);
                LbMensagem.Text = "Conexão efetuada com sucesso!";
            }
            catch (Exception ex)
            {
                LbMensagem.Text = "Erro ao conectar: " + ex.Message;
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Program.conexao.DesconectaDB();
                LbMensagem.Text = "Conexão encerrada.";
            }
            catch (Exception ex)
            {
                LbMensagem.Text = "Erro ao encerrar: " + ex.Message;
            }
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}
