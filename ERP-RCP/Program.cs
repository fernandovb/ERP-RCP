using System;
using System.Windows.Forms;
using CamadaApresentacao;

namespace ERP_RCP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LOG00 f = new LOG00();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new RCP00(f.usuario, f.empresa));
        }
    }
}
