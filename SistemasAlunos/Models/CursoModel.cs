namespace SistemasAlunos.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<DisciplinaModel> Disciplinas { get; set; }

    }
}
