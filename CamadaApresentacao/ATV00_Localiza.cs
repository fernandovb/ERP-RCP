﻿/* Formulário ATV00_Localiza: responsável pela interface para localização dados, 
 * realizando consultas e auxiliando as transações ATV02 e ATV03 passando os parâmetros de carga,
 */

using System;
using System.Windows.Forms;
using CamadaNegocio.CnDBA;

namespace CamadaApresentacao
{
    public partial class ATV00_Localiza : Form
    {
        public ATV00_Localiza()
        {
            InitializeComponent();
        }

        public void Localizar()
        {
            DgResultado.DataSource = null;
            DsPesquisa.Clear();
            //A matriz será utilizada para enviar os dados à consulta (matriz[L, C])
            //Determinaremos que a coluna 0 será o campo a filtrar e a coluna 1 será o valor do filtro
            //Cada linha determinará o conjunto de filtro a ser executado
            string[,] busca = new string[2,2];
            busca[0, 0] = "atv_codigo";
            busca[0, 1] = TbAtividade.Text;
            busca[1, 0] = "atv_descricao";
            busca[1, 1] = TbDescricao.Text;
            try
            {
                NATV01 Localizar = new NATV01(TbAtividade.Text);
                Localizar.LocalizarAtividade(busca);
                DgResultado.DataSource = Localizar.DsLocalizar;
                DgResultado.DataMember = "dba_atividade";
                BtConfirma.Enabled = true;
            }
            catch (Exception ex)
            {
                SslMensagem.Text = "Valores não localizados. " + ex.Message;
                BtConfirma.Enabled = false;
            }
        }

        private void BtPesquisas_Click(object sender, EventArgs e)
        {
            Localizar();
        }

        private void BtConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                ClRetorno.RetornoPesquisa = DgResultado.CurrentRow.Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                SslMensagem.Text = ex.Message;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
