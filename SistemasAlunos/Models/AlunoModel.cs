using SistemasAlunos.Enum;

namespace SistemasAlunos.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Ra { get; set; }
        public ICollection<CursoModel> Curso { get; set; }
        public StatusAluno Status { get; set; }
        public string Foto { get; set; }


    }
}
