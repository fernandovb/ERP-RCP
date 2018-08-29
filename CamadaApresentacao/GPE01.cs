/* GPE01 (Gestão de Parâmetros de Empresa - Formulário 01)
*/

using System;
using System.Windows.Forms;
using System.Globalization;
using CamadaNegocio.CnDBA;

namespace CamadaApresentacao
{
    public partial class GPE01 : Form
    {
        private int acao;
        private int Codigo;
        private string NFormal;
        private string NAlternativo;

        public GPE01()
        {
            this.acao = 1; //Inicia formulário com inclusão
            InitializeComponent();
        }

        public GPE01(int acao)
        {
            this.acao = acao; 
            InitializeComponent();
        }

        private void GPE01_Shown(object sender, EventArgs e)
        {
            TpSocietario();
            Situacao();
            BtGravar.Enabled = false;
            BtCancel.Enabled = false;
            if (acao == 1)
                BtAuditoria.Enabled = false;
        }

        private void Situacao()
        {
            foreach (string str in Enum.GetNames(typeof(ClRetorno.Situacao)))
                CbSituacao.Items.Add(str);
        }

        private int RetornaSituacao(string DescSituacao)
        {
            int x = -1;
            foreach (int i in Enum.GetValues(typeof(ClRetorno.Situacao)))
            {
                if (Enum.GetName(typeof(ClRetorno.Situacao), i) == DescSituacao)
                    x = i;
            }
            return x;
        }

        private void TpSocietario()
        {
            NGPE01 Tipos = new NGPE01(ClRetorno.EmpUso);
            Tipos.TpSocietario();
            if (Tipos.DtTipos != null)
            {
                for (int i=0; i < Tipos.DtTipos.Rows.Count; i++)
                {
                    CbTSocietario.Items.Add(Tipos.DtTipos.Rows[i]["tps_sigla"].ToString());
                }
            }
        }

        private void CbSituacao_Leave(object sender, EventArgs e)
        {
            try
            {
                if (RetornaSituacao(CbSituacao.SelectedItem.ToString()) == 3)
                {
                    LbDtEncerramento.Enabled = true;
                    LbDtEncerramento.Visible = true;
                    TbDtEncerramento.Enabled = true;
                    TbDtEncerramento.Visible = true;
                    if (TbDtEncerramento.Value <= TbDtEncerramento.MinDate)
                        TbDtEncerramento.Value = DateTime.Now;
                }
                else
                {
                    TbDtEncerramento.Value = TbDtEncerramento.MinDate;
                    LbDtEncerramento.Enabled = false;
                    LbDtEncerramento.Visible = false;
                    TbDtEncerramento.Enabled = false;
                    TbDtEncerramento.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria empresa no NGPE01
                NGPE01 Inserir = new NGPE01(int.Parse(TbCodigo.Text),
                                            TbNFormal.Text,
                                            TbNAlternativo.Text,
                                            char.Parse(RetornaSituacao(CbSituacao.SelectedItem.ToString()).ToString()),
                                            CbTSocietario.Text,
                                            double.Parse(TbCapital.Text),
                                            double.Parse(TbQuotas.Text),
                                            TbDtCriacao.Value,
                                            TbDtEncerramento.Value,
                                            TbPerFechamento.Text);
                //Cria os sócios na lista que da classe NGPE01 que estão no DgSocios com NSE01
                foreach (DataGridViewRow i in DgSocios.Rows)
                {
                    NSE01 Socio = new NSE01(int.Parse(TbCodigo.Text),
                                            int.Parse(i.Cells[SocCodigo.Index].Value.ToString()),
                                            char.Parse(RetornaSituacao(i.Cells[SocSituacao.Index].Value.ToString()).ToString()),
                                            i.Cells[SocNome.Index].Value.ToString(),
                                            i.Cells[SocFederal.Index].Value.ToString(),
                                            double.Parse(i.Cells[SocCapital.Index].Value.ToString()),
                                            double.Parse(i.Cells[SocQuotas.Index].Value.ToString()));
                    Inserir.LSocios.Add(Socio);
                }
                //Executa inclusão no banco de dados através da classe NGPE01 
                SslMensagem.Text = Inserir.InserirEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int SequenciaCodigo(DataGridView Grade)
        {
            return ((Grade.RowCount * 10) + 10);
        }

        private double SomaCapital()
        {
            double capital = 0;
            for (int i = 0; i < DgSocios.RowCount; i++)
            {
                if (DgSocios.Rows[i].Cells[1].Value.ToString() == "Ativo")
                    capital += Convert.ToDouble(DgSocios.Rows[i].Cells[4].Value);
            }
            return capital;
        }

        private double SomaQuotas()
        {
            double quotas = 0;
            try
            {
                for (int i = 0; i < DgSocios.RowCount; i++)
                {
                    if (DgSocios.Rows[i].Cells[1].Value.ToString() == "Ativo")
                        quotas += Convert.ToDouble(DgSocios.Rows[i].Cells[5].Value);
                }
            }
            catch(Exception ex)
            {
                SslMensagem.Text = ex.Message;
            }
            return quotas;
        }

        /// ********************************** ///
        ///   Valida controles do formulário   ///
        /// ********************************** ///

        private void LimpaCampos()
        {
            try
            {
                if (acao == 1)
                {
                    TbCodigo.Text = "";
                    CbSituacao.Text = "";
                    TbNFormal.Text = "";
                    TbNAlternativo.Text = "";
                    CbTSocietario.Text = "";
                    TbDtCriacao.Value = DateTime.Now;
                    if (TbDtEncerramento.Enabled == true)
                        TbDtEncerramento.Enabled = false;
                    TbDtEncerramento.Value = TbDtEncerramento.MinDate;
                    TbPerFechamento.Text = "31/12";
                    if (DgSocios.RowCount > 0)
                        DgSocios.Rows.Clear();
                    if (DgMembros.RowCount > 0)
                        DgMembros.Rows.Clear();
                    SslMensagem.Text = "";
                    BtGravar.Enabled = false;
                    BtCancel.Enabled = false;
                    TbCapital.Text = "0,00";
                    TbQuotas.Text = "0,00";
                    TbCodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                SslMensagem.Text = ex.Message;
            }
        }

        private void ValidaCampos()
        {
            if (Codigo.ToString() != TbCodigo.Text || NFormal != TbNFormal.Text || NAlternativo != TbNAlternativo.Text)
            {
                BtGravar.Enabled = true;
                BtCancel.Enabled = true;
            }
        }

        private void Campos_Leave(object sender, EventArgs e)
        {
            ValidaCampos();
        }

        /// ********************************** ///
        ///   Controles e Métodos dos Sócios   ///
        /// ********************************** ///

        private void BtNewSocio_Click(object sender, EventArgs e)
        {
            DgSocios.Rows.Add(SequenciaCodigo(DgSocios), "Ativo", "", "", 0, 0);
        }

        private Boolean ValidaSocNome(DataGridViewCell cel)
        {
            try
            {
                string teste = cel.Value.ToString().Trim();
                if (teste.Length < 3)
                {
                    cel.ErrorText = "Nome não pode ser nulo!";
                    DgSocios.Rows[cel.RowIndex].ErrorText = "Nome não pode ser nulo!";
                    return false;
                }
                else if (teste == string.Empty || teste == "")
                {
                    cel.ErrorText = "Nome deve ser um valor válido!";
                    DgSocios.Rows[cel.RowIndex].ErrorText = "Nome deve ser um valor válido!";
                    return false;
                }
                else
                {
                    cel.ErrorText = string.Empty;
                    DgSocios.Rows[cel.RowIndex].ErrorText = string.Empty;
                    return true;
                }
            }
            catch (Exception ex)
            {
                cel.ErrorText = "Nome: " + ex.Message;
                DgSocios.Rows[cel.RowIndex].ErrorText = "Nome: " + ex.Message;
                return false;
            }
        }

        private bool ValidaCapital(DataGridViewCell cel)
        {
            try
            {
                bool result = double.TryParse(cel.Value.ToString(), out double valor);
                if (result)
                {
                    if (valor == 0)
                    {
                        cel.ErrorText = "Valor do capital não pode ser zero.";
                        DgSocios.Rows[cel.RowIndex].ErrorText = "Valor do capital não pode ser zero.";
                        return false;
                    }
                    else
                    {
                        cel.ErrorText = string.Empty;
                        DgSocios.Rows[cel.RowIndex].ErrorText = string.Empty;
                        return true;
                    }
                }
                else
                {
                    cel.ErrorText = "Capital só deve conter números";
                    DgSocios.Rows[cel.RowIndex].ErrorText = "Capital só deve conter números";
                    return false;
                }
            }
            catch (Exception ex)
            {
                cel.ErrorText = "Capital: " + ex.Message;
                DgSocios.Rows[cel.RowIndex].ErrorText = "Capital: " + ex.Message;
                return false;
            }
        }

        private bool ValidaQuotas(DataGridViewCell cel)
        {
            try
            {
                bool result = double.TryParse(cel.Value.ToString(), out double valor);
                if (result)
                {
                    if (valor == 0)
                    {
                        cel.ErrorText = "Quantidade de quotas não pode ser zero.";
                        DgSocios.Rows[cel.RowIndex].ErrorText = "Quantidade de quotas não pode ser zero.";
                        return false;
                    }
                    else
                    {
                        cel.ErrorText = string.Empty;
                        DgSocios.Rows[cel.RowIndex].ErrorText = string.Empty;
                        return true;
                    }
                }
                else
                {
                    cel.ErrorText = "Quotas só devem conter números";
                    DgSocios.Rows[cel.RowIndex].ErrorText = "Quotas só devem conter números";
                    return false;
                }
            }
            catch (Exception ex)
            {
                cel.ErrorText = "Quotas: " + ex.Message;
                DgSocios.Rows[cel.RowIndex].ErrorText = "Quotas: " + ex.Message;
                return false;
            }
        }

        private void DgSocios_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow Linha = DgSocios.Rows[e.RowIndex];
            DataGridViewCell CellNome = Linha.Cells[SocNome.Index];
            DataGridViewCell CellCapital = Linha.Cells[SocCapital.Index];
            DataGridViewCell CellQuota = Linha.Cells[SocQuotas.Index];
            e.Cancel = !(ValidaSocNome(CellNome) && ValidaCapital(CellCapital) && ValidaQuotas(CellQuota));
        }

        private void DgSocios_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            TbCapital.Text = SomaCapital().ToString("F2", CultureInfo.CurrentCulture);
            TbQuotas.Text = SomaQuotas().ToString("F2", CultureInfo.CurrentCulture);
        }

        /// *********************************** ///
        ///   Controles e Métodos dos Membros   ///
        /// *********************************** ///

        private void BtNovoMembro_Click(object sender, EventArgs e)
        {
            DgMembros.Rows.Add(SequenciaCodigo(DgMembros), "Ativo", "", "", "(xx)xxxx-xxxx");
        }

        private Boolean ValidaMemNome(DataGridViewCell cel)
        {
            try
            {
                string teste = cel.Value.ToString().Trim();
                if (teste.Length < 3)
                {
                    cel.ErrorText = "Nome não pode ser nulo!";
                    DgMembros.Rows[cel.RowIndex].ErrorText = "Nome não pode ser nulo!";
                    return false;
                }
                else if (teste == string.Empty || teste == "")
                {
                    cel.ErrorText = "Nome deve ser um valor válido!";
                    DgMembros.Rows[cel.RowIndex].ErrorText = "Nome deve ser um valor válido!";
                    return false;
                }
                else
                {
                    cel.ErrorText = string.Empty;
                    DgMembros.Rows[cel.RowIndex].ErrorText = string.Empty;
                    return true;
                }
            }
            catch (Exception ex)
            {
                cel.ErrorText = "Nome: " + ex.Message;
                DgMembros.Rows[cel.RowIndex].ErrorText = "Nome: " + ex.Message;
                return false;
            }
        }

        private void DgMembros_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow Linha = DgMembros.Rows[e.RowIndex];
            DataGridViewCell CellNome = Linha.Cells[MemNome.Index];
            e.Cancel = !(ValidaMemNome(CellNome));
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void TbNFormal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TbNFormal.Text.Trim().Length == 0)
            {
                EpEmpresa.SetError(TbNFormal, "Nome Formal é obrigatório, favor informar.");
                e.Cancel = true;
            }
            else
            {
                EpEmpresa.SetError(TbNFormal, "");
                e.Cancel = false;
            }
        }
    }
}
