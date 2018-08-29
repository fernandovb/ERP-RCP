using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio.CnDBA
{
    public class NSE01
    {
        public int Empresa { get; private set; }
        public int Codigo { get; private set; }
        public char Situacao { get; private set; }
        public string Nome { get; private set; }
        public string Federal { get; private set; }
        public double ValorPart { get; private set; }
        public double QuotaPart { get; private set; }

        public NSE01(int Empresa, int Codigo, char Situacao, string Nome, string Federal, double ValorPart, double QuotaPart)
        {
            this.Empresa = Empresa;
            this.Codigo = Codigo;
            this.Situacao = Situacao;
            this.Nome = Nome;
            this.Federal = Federal;
            this.ValorPart = ValorPart;
            this.QuotaPart = QuotaPart;
        }

        public override string ToString()
        {
            string socio = "";
            socio = Empresa + "-" + Codigo + "-" + Nome + "/n" + "Situação " + Situacao;
            return socio;
        }

        public string InserirSocio()
        {
            string mensagem = "";
            if (Empresa == 0)
                mensagem = "Empresa não pode ser nulo";
            else if (Codigo == 0)
                mensagem = "Código inválido. Houve erro na inserção do sócio.";
            else if (string.IsNullOrEmpty(Nome))
                mensagem = "Nome do sócio na linha " + Codigo + " não pode ser nulo";
            else if (string.IsNullOrEmpty(Federal) || Federal.Length < 11)
                mensagem = "Registro federal inválido ou incorreto, favor verificar!";
            else if (ValorPart == 0)
                mensagem = "Valor da participação não pode ser zero.";
            else if (QuotaPart == 0)
                mensagem = "Valor das quotas não pode ser zero.";
            else
            {
                mensagem = "Ok";
            }
            return mensagem;
        }

        public void AlterarSocio()
        {

        }

        public void CarregarSocio()
        {

        }
    }
}
