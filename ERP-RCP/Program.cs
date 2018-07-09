using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_RCP.CmDados;
using ERP_RCP.Telas;

namespace ERP_RCP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.

        public static ClConexao conexao;


        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrLogin f = new FrLogin();
            if (f.ShowDialog() == DialogResult.OK)
                Application.Run(new FrMenu(f.usuario, f.empresa));
        }
    }
}
