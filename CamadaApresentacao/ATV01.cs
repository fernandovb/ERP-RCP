using System;
using System.Windows.Forms;
using CamadaNegocio.CnDBA;

namespace CamadaApresentacao
{
    public partial class ATV01 : Form
    {
        private string codigo;
        private string descricao;
        private string observacao;
        private int acao;

        public ATV01()
        {
            //Inicia objeto sem valores. Utilizado para inserção.
            this.acao = 1;
            InitializeComponent();
        }

        public ATV01(int acao, string codigo, string descricao, string observacao)
        {
            //Inicia objeto com valores. Utilizado para alterações e consultas.
            this.codigo = codigo;
            this.descricao = descricao;
            this.observacao = observacao;
            this.acao = acao;
            InitializeComponent();
        }

        private void ATV01_Shown(object sender, EventArgs e)
        {
            BtGravar.Enabled = false;
            BtCancelar.Enabled = false;
            TbCodigo.Text = codigo;
            TbDescricao.Text = descricao;
            TbObservacao.Text = observacao;
            if (acao == 2)
            {
                this.Text = "Modificar Atividade";
                TbCodigo.Enabled = false;
                TbDescricao.Focus();
            }
            else if (acao == 3)
            {
                this.Text = "Consultar Atividade";
                TbCodigo.Enabled = false;
                TbDescricao.Enabled = false;
                TbObservacao.Enabled = false;
            }
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            NATV01 a = new NATV01(TbCodigo.Text, TbDescricao.Text, TbObservacao.Text);
            if (acao == 1)
            {
                if (TbCodigo.Text != "" & TbDescricao.Text != "")
                    SslMensagem.Text = a.InserirAtividade();
            }
            else if (acao == 2)
            {
                if (TbCodigo.Text != "" & TbDescricao.Text != "")
                {
                    SslMensagem.Text = a.AlterarAtividade();
                    descricao = TbDescricao.Text;
                    observacao = TbObservacao.Text;
                }
            }
            LimpaCampos();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            ConfirmaMudanca();
        }

        private void LimpaCampos()
        {
            if (acao == 1)
            {
                TbCodigo.Text = "";
                TbDescricao.Text = "";
                TbObservacao.Text = "";
                TbCodigo.Focus();
                BtGravar.Enabled = false;
                BtCancelar.Enabled = false;
            }
            if (acao == 2)
            {
                TbCodigo.Text = codigo;
                TbDescricao.Text = descricao;
                TbObservacao.Text = observacao;
                TbDescricao.Focus();
                BtGravar.Enabled = false;
                BtCancelar.Enabled = false;
            }
        }

        private void ConfirmaMudanca()
        {
            if (codigo != TbCodigo.Text | descricao != TbDescricao.Text | observacao != TbObservacao.Text)
            {
                BtGravar.Enabled = true;
                BtCancelar.Enabled = true;
            }
        }
    }
}
