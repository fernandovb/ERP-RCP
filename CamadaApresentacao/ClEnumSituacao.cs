using System.ComponentModel;

namespace CamadaApresentacao
{
    public enum ClEnumSituacao
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 2,
        [Description("Encerrado")]
        Encerrado = 3,
        [Description("Bloqueado")]
        Bloqueado = 9,
    }
}
