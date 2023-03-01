using System.ComponentModel;

namespace SistemasAlunos.Enum
{
    public enum StatusAluno
    {
        [Description("Aluno Aprovado")]
        Aprovado = 1,
        [Description("Aluno Reprovado")]
        Reprovado = 2
    }
}
