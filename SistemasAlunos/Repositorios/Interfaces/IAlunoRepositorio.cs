using SistemasAlunos.Enum;
using SistemasAlunos.Models;

namespace SistemasAlunos.Repositorios.Interfaces
{
    public interface IAlunoRepositorio
    {
        Task<List<AlunoModel>> BuscarAlunos();
        Task<AlunoModel> BuscarAlunoPorId(int id);
        Task<AlunoModel> BuscarAlunoPorRA(int ra);
        Task<AlunoModel> BuscarAlunoPorCurso(string nomeCurso);
        Task<AlunoModel> BuscarAlunoPorStatus(StatusAluno status);
        Task<AlunoModel> AdicionarAluno(AlunoModel aluno);
        Task<AlunoModel> EditarAluno(AlunoModel aluno, int id);
        Task<bool> ExcluirAluno(int id);

    }
}
