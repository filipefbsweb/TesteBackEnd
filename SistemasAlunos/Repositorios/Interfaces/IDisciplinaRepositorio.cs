using SistemasAlunos.Models;

namespace SistemasAlunos.Repositorios.Interfaces
{
    public interface IDisciplinaRepositorio
    {
        Task<List<DisciplinaModel>> BuscarDisciplinas();

        Task<DisciplinaModel> BuscarDisciplinaPorNome(string nome);

        Task<DisciplinaModel> AdicionarDisciplina(DisciplinaModel disciplina);
    }
}
