using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NAUDDATA
    {
        public string Empresa { get; private set; }
        public string Codigo { get; private set; }
        public string Tabela { get; private set; }
        public DataSet DsAudData;

        public NAUDDATA(string Codigo, string Tabela)
        {
            this.Codigo = Codigo;
            this.Tabela = Tabela;
        }

        public string BuscaMudanca()
        {
            string mensagem = "";
            try
            {
                string Comando = "select " +
                                 "data_hora as Data, " +
                                 "campo as Campo, " +
                                 "usuario as 'Usuário', " +
                                 "acao as 'Ação', " +
                                 "old_value as 'Anterior', " +
                                 "new_value as 'Novo' " +
                                 "from " + Tabela +" " +
                                 "where codigo = '" + Codigo + "' " +
                                 "order by data_hora;";
                DAUDATA Auditoria = new DAUDATA(Comando, Tabela);
                DsAudData = new DataSet();
                Auditoria.BuscaMudanca(Comando, Tabela);
                Auditoria.MaAuditoria.Fill(DsAudData, Tabela);
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            return mensagem;
        }
    }
}
