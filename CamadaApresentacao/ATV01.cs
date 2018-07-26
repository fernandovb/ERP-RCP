/* Formulário ATV01: responsável pela interface de acesso aos dados, tanto para consulta,
 * como para inclusão e alteração dos dados.
 * Alem de manipulação dos dados, também permite varificação de auditoria de dados, mostrando
 * quais alterações ocorreram, em que data e quem as fez.
 */

using System;
using System.Windows.Forms;
using CamadaNegocio.CnDBA;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class ATV01 : Form
    {
        //Variáveis de comunicação para recebimento de dados e manipulação de eventos
        private string codigo;
        private string descricao;
        private string observacao;
        //Variável para determinar o tipo de ação
        private int acao;

        public ATV01()
        {
            //Inicia objeto sem valores. Utilizado para inserção.
            this.acao = 1;//Ação 1 indica que é inclusão
            InitializeComponent();
        }

        public ATV01(int acao, string codigo, string descricao, string observacao)
        {
            //Inicia objeto com valores. Utilizado para alterações e consultas.
            this.codigo = codigo;
            this.descricao = descricao;
            this.observacao = observacao;
            this.acao = acao;//Recebe ação de outro formulário. Se 2, alteração, se 3, consulta
            InitializeComponent();
        }

        private void ATV01_Shown(object sender, EventArgs e)
        {
            //Desativa os botões
            BtGravar.Enabled = false;
            BtCancelar.Enabled = false;
            if (acao == 1)
                BtAuditoria.Enabled = false; //Desativa somente na inclusão, pois não há código a ser pesquisado
            //Alimenta os campos com os valores recebidos. Se for 2 ou 3, há dados, se for 1, serão vazios
            TbCodigo.Text = codigo;
            TbDescricao.Text = descricao;
            TbObservacao.Text = observacao;
            //Se for ação 2 (alteração), altera o título do formulário e bloqueia campo código
            if (acao == 2)
            {
                this.Text = "Modificar Atividade";
                TbCodigo.ReadOnly = true;
                TbDescricao.Focus();
            }
            //Se for ação 3 (consulta), altera o título do formulário e bloqueia todos os campos
            else if (acao == 3)
            {
                this.Text = "Consultar Atividade";
                TbCodigo.ReadOnly = true;
                TbDescricao.ReadOnly = true;
                TbObservacao.ReadOnly = true;
            }
            //Somente o botão BtSair não é bloqueado, ficando sempre ativo para uso
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            //Chama CamadaNegócio, criando objeto "atividade" com os dados preenchidos
            NATV01 a = new NATV01(TbCodigo.Text, TbDescricao.Text, TbObservacao.Text);
            //Se for ação 1 (inclusão), valida se os campos básicos realmente estão preenchidos
            //depois chama o método de inserção
            if (acao == 1)
            {
                if (TbCodigo.Text != "" & TbDescricao.Text != "")
                    SslMensagem.Text = a.InserirAtividade();
            }
            //Se for ação 2 (alteração), valida se os campos básicos realmente estão preenchidos
            //depois chama o método de alteraão
            else if (acao == 2)
            {
                if (TbCodigo.Text != "" & TbDescricao.Text != "")
                {
                    SslMensagem.Text = a.AlterarAtividade();
                    //Após executar a alteração no BD, atualiza campos da memória
                    descricao = TbDescricao.Text;
                    observacao = TbObservacao.Text;
                }
            }
            //Limpa os campos do formulário
            LimpaCampos();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            //Limpa os campos do formulário
            LimpaCampos();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            //Fecha a transação
            Close();
        }

        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            //Confirma alteração dos campos do formulário e libera os botões
            ConfirmaMudanca();
        }

        private void LimpaCampos()
        {
            //Se for ação 1 (inclusão) limpa os campos do formulário e bloqueia os botões
            if (acao == 1)
            {
                TbCodigo.Text = "";
                TbDescricao.Text = "";
                TbObservacao.Text = "";
                TbCodigo.Focus();
                BtGravar.Enabled = false;
                BtCancelar.Enabled = false;
            }
            //Se for ação 2 (alteração) retorna os valores da memória e bloqueia os botões
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
            //Verifica se houve alguma mudança nos campos digitados em relação as variáveis em memória
            if (codigo != TbCodigo.Text | descricao != TbDescricao.Text | observacao != TbObservacao.Text)
            {
                //Verifica se não é uma consulta (ação 3) e desbloqueia os botões
                if (acao != 3)
                {
                    BtGravar.Enabled = true;
                    BtCancelar.Enabled = true;
                }
            }
            //Valida se o código está preenchido
            if (codigo != "")
            {
                //Verifica se não é uma inclusão (ação 1) e debloqueia o botão de BtAuditoria
                if (acao != 1)
                    BtAuditoria.Enabled = true;
            }
            //Limpa mensagens de rodapé do formulário
            SslMensagem.Text = "";
        }

        private void BtAuditoria_Click(object sender, EventArgs e)
        {
            AUDDATA FAuditoria = new AUDDATA(TbCodigo.Text, "dba_atividade");
            FAuditoria.ShowDialog();
        }
    }
}
