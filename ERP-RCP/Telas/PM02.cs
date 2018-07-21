using System;
using System.Windows.Forms;

namespace ERP_RCP.Telas
{
    public partial class PM02 : Form
    {
        public PM02()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtBusca_Click(object sender, EventArgs e)
        {
            FrConsPessoa f = new FrConsPessoa();
            if (f.ShowDialog() == DialogResult.OK)
            {
                TbCodPessoa.Text = ClRetorno.CodPessoa;
            }
        }
    }
}
