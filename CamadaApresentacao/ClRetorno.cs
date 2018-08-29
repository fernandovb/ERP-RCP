using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CamadaApresentacao
{
    public static class ClRetorno
    {
        public static string RetornoPesquisa;
        public static int EmpUso;
        public enum Situacao { Ativo=1, Inativo=2, Encerrado=3, Cancelado=4, Bloqueado=9 };
        public enum Genero { Marculino=1, Feminino=2 };
        public enum OrientacaoSexual { Heterossexual=1, Homossexual=2, Bissexual=3, Transexual=4, Outros=5}
    }
}
