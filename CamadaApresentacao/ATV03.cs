/* Formulário ATV03: responsável pela simples exibição dos dados.
 * Embora este formulário herde os controles de ATV02, ele não permite que as alterações 
 * ocorram em ATV01, quando carregados.
 */

using System;

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
