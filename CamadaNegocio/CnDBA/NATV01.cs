using System.Data;
using CamadaDados.CdDBA;

namespace CamadaNegocio.CnDBA
{
    public class NATV01
    {
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public string Observacao { get; private set; }
        public object MaPesquisa { get; private set; }
        public DataSet DsLocalizar;

        public NATV01(string Codigo, string Descricao, string Observacao)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.Observacao = Observacao;
        }

        public NATV01(string codigo)
        {
            this.Codigo = codigo;
        }

        public string InserirAtividade()
        {
            string mensagem = "";
            if (Codigo == "")
                mensagem = "Código inválido! Favor verificar.";
            else if (Descricao == "")
                mensagem = "O campo Descrição necessita de um valor válido.";
            else
            {
                DATV01 FInserir = new DATV01(Codigo, Descricao, Observacao);
                mensagem = FInserir.InserirAtividade();
            }
            return mensagem;
        }

        public string AlterarAtividade()
        {
            string mensagem = "";
            if (Codigo == "")
                mensagem = "Código inválido! Favor verificar.";
            else if (Descricao == "")
                mensagem = "O campo Descrição necessita de um valor válido.";
            else
            {
                DATV01 d = new DATV01(Codigo, Descricao, Observacao);
                mensagem = d.AlterarAtividade();
            }
            return mensagem;
        }

        public string CarregarAtividade(string codigo)
        {
            string mensagem = "Carga defeituosa!!!";
            DATV01 d = new DATV01(codigo);
            mensagem = d.CarregaAtividade(codigo);
            Descricao = d.Descricao;
            Observacao = d.Observacao;
            return mensagem;
        }

        public void LocalizarAtividade(string[,] criterio)
        {
            string comando = ""; //Variável para inclusão do comando select do SQL
            string busca = ""; //Variável para montar critérios de busca SQL
            DsLocalizar = new DataSet();

            //O número 2 (i<2) é devido ao número de argumentos gerados em ATV00_Localiza.cs
            for (int i = 0; i < 2; i++)
            {
                if (criterio[i, 1] != "")
                {
                    if (busca != "" & i > 0)
                        busca = busca + " and ";
                    busca = busca + criterio[i, 0] + " like '%" + criterio[i, 1] + "%'";
                }
            }

            //Verifica se houve informação das condições de filtro e completa o comando
            if (busca != "")
            {
                comando = "SELECT atv_codigo, atv_descricao FROM dba_atividade WHERE " + busca;
                DATV01 Consulta = new DATV01(Codigo, Descricao, Observacao);
                Consulta.LocalizarAtividade(comando);
                Consulta.MaPesquisa.Fill(DsLocalizar, "dba_atividade");
            }
        }
    }
}
