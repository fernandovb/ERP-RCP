/* NGPE01 Módulo para interação entre telas e o módulo de dados. Faz a validação das regras
 * de negócio e libera o módulo DGPE01 para atualizar o banco de dados.
 * Também auxilia na interação das telas, fazendo consultas e carga das informações.
*/

using System;
using System.Collections.Generic;
using System.Data;
using CamadaDados.CdDBA;

namespace CamadaNegocio.CnDBA
{
    public class NGPE01
    {
        public int Codigo { get; private set; }
        public string Nome_Formal { get; private set; }
        public string Nome_Alternativo { get; private set; }
        public char Situacao { get; private set; }
        public string Tp_Societario { get; private set; }
        public double Cap_Social { get; private set; }
        public double Quotas { get; private set; }
        public DateTime DtCriacao { get; private set; }
        public DateTime DtEncerramento { get; private set; }
        public string PerFechamento { get; private set; }
        public DataTable DtTipos;
        public List<NSE01> LSocios;

        public NGPE01(int Codigo)
        {
            this.Codigo = Codigo;
        }

        public NGPE01(int Codigo,
                      string Nome_Formal,
                      string Nome_Alternativo,
                      char Situacao,
                      string Tp_Societario,
                      double Cap_Social,
                      double Quotas,
                      DateTime DtCriacao,
                      DateTime DtEncerramento,
                      string PerFechamento)
        {
            this.Codigo = Codigo;
            this.Nome_Formal = Nome_Formal;
            this.Nome_Alternativo = Nome_Alternativo;
            this.Situacao = Situacao;
            this.Tp_Societario = Tp_Societario;
            this.Cap_Social = Cap_Social;
            this.Quotas = Quotas;
            this.DtCriacao = DtCriacao;
            this.DtEncerramento = DtEncerramento;
            this.PerFechamento = PerFechamento;
            LSocios = new List<NSE01>();
        }

        public double CapitalTotal()
        {
            return 0;
        }

        public double QuotaTotal()
        {
            return 0;
        }

        public string InserirEmpresa()
        {
            string mensagem = "";
            if (Codigo == 0)
                mensagem = "Código inválido! Favor verificar.";
            else if (Nome_Formal == string.Empty)
                mensagem = "O campo Descrição necessita de um valor válido.";
            else if (Cap_Social == 0)
                mensagem = "Valor do capital social deve ser maior que zero";
            else if (Quotas == 0)
                mensagem = "Quantidade de quotas deve ser maior que zero";
            else if (Situacao == 3 & (DtEncerramento.CompareTo(DateTime.MinValue) == 1))
                mensagem = "Favor informar a data de encerramento da empresa.";
            else
            {
                if (Situacao != 3)
                    DtEncerramento = DateTime.MinValue;
                DGPE01 Inserir = new DGPE01(Codigo,
                                            Nome_Formal,
                                            Nome_Alternativo,
                                            Situacao,
                                            Tp_Societario,
                                            Cap_Social,
                                            Quotas,
                                            DtCriacao,
                                            DtEncerramento,
                                            PerFechamento,
                                            LDSocios(LSocios));
                mensagem = Inserir.InserirEmpresa();
                for (int i=0; i<LSocios.Count; i++)
                {
                    DSE01 SInserir = new DSE01(LSocios[i].Empresa,
                                               LSocios[i].Codigo,
                                               LSocios[i].Situacao,
                                               LSocios[i].Nome,
                                               LSocios[i].Federal,
                                               LSocios[i].ValorPart,
                                               LSocios[i].QuotaPart);
                    SInserir.InserirSocio();
                }
            }
            return mensagem;
        }

        public void AlterarEmpresa()
        {

        }

        public void CarregarEmpresa()
        {

        }

        public void LocalizarEmpresa()
        {

        }

        public void TpSocietario()
        {
            DtTipos = new DataTable();
            DGPE01 Tipos = new DGPE01(Codigo);
            Tipos.TpSocietario();
            Tipos.MaPesquisa.Fill(DtTipos);            
        }

        private List<DSE01> LDSocios(List<NSE01> LSocios)
        {
            List<DSE01> l = new List<DSE01>();
            for(int i=0; i<LSocios.Count; i++)
            {
                l.Add(new DSE01(LSocios[i].Empresa,
                                LSocios[i].Codigo,
                                LSocios[i].Situacao,
                                LSocios[i].Nome,
                                LSocios[i].Federal,
                                LSocios[i].ValorPart,
                                LSocios[i].QuotaPart));
            }
            return l;
        }
    }
}
