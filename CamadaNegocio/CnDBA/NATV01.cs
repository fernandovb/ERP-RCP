using System;
using System.Data;
using MySql.Data.MySqlClient;
using CamadaDados.CdDBA;

namespace CamadaNegocio.CnDBA
{
    public class NATV01 : IDisposable
    {
        bool disposed = false;
        public string codigo { get; private set; }
        public string descricao { get; private set; }
        public string observacao { get; private set; }
        public object MaPesquisa { get; private set; }
        public static DataSet DsLocalizar;

        public NATV01(string codigo, string descricao, string observacao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.observacao = observacao;
        }

        public NATV01(string codigo)
        {
            this.codigo = codigo;
            //CarregarAtividade();
        }

        public string InserirAtividade()
        {
            string mensagem = "";
            if (codigo == "")
                mensagem = "Código inválido! Favor verificar.";
            else if (descricao == "")
                mensagem = "O campo Descrição necessita de um valor válido.";
            else
            {
                DATV01 FInserir = new DATV01(codigo, descricao, observacao);
                mensagem = FInserir.InserirAtividade();
            }
            return mensagem;
        }

        public string AlterarAtividade()
        {
            string mensagem = "";
            if (codigo == "")
                mensagem = "Código inválido! Favor verificar.";
            else if (descricao == "")
                mensagem = "O campo Descrição necessita de um valor válido.";
            else
            {
                DATV01 d = new DATV01(codigo, descricao, observacao);
                mensagem = d.AlterarAtividade();
            }
            return mensagem;
        }

        public string CarregarAtividade(string codigo)
        {
            string mensagem = "Carga defeituosa!!!";
            DATV01 d = new DATV01(codigo);
            mensagem = d.CarregaAtividade(codigo);
            descricao = d.descricao;
            observacao = d.observacao;
            return mensagem;
        }

        public static void LocalizarAtividade(string[,] criterio)
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
                DATV01.LocalizarAtividade(comando);
                DATV01.MaPesquisa.Fill(DsLocalizar, "dba_atividade");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            //if (disposing)
            //{
            //}
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
