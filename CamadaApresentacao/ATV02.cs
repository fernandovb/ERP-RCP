using System;
using System.Windows.Forms;
using CamadaNegocio.CnDBA;

namespace CamadaApresentacao
{
    public partial class ATV02 : Form
    {
        public ATV02()
        {
            InitializeComponent();
        }

        private void BtBusca_Click(object sender, EventArgs e)
        {
            ATV00_Localiza FBusca = new ATV00_Localiza();
            if (FBusca.ShowDialog() == DialogResult.OK)
            {
                TbAtividade.Text = ClRetorno.RetornoPesquisa;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            int acao = 0;
            NATV01 a = new NATV01(TbAtividade.Text);
            SslMensagem.Text = a.CarregarAtividade(TbAtividade.Text);
            if (SslMensagem.Text == "Dados carregados.")
            {
                if (this.Name == "ATV02")
                    acao = 2;
                else if (this.Name == "ATV03")
                    acao = 3;
                ATV01 FAlterar = new ATV01(acao, a.Codigo, a.Descricao, a.Observacao);
                FAlterar.ShowDialog();
                SslMensagem.Text = "";
            }
        }
    }
}