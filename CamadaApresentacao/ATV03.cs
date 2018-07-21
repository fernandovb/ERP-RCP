using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class ATV03 : CamadaApresentacao.ATV02
    {
        public ATV03()
        {
            InitializeComponent();
        }

        private void ATV03_Shown(object sender, EventArgs e)
        {
            this.Text = "Consultar Atividade";
        }
    }
}
