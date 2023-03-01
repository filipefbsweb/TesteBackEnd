using SistemasAlunos.Models;

namespace SistemasAlunos.Repositorios.Interfaces
{
    public interface ICursoRepositorio
    {
        Task<List<CursoModel>> BuscarCursos();

        Task<CursoModel> BuscarCursoPorNome(string nome);

        Task<CursoModel> AdicionarNovoCurso(CursoModel curso);
    }
}
