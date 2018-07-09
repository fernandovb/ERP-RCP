using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_RCP
{
    public partial class FrMenu : Form
    {
        public string user;
        public int empresa;

        public FrMenu(string user, int empresa)
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
    }
}
