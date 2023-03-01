using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Data;
using SistemasAlunos.Enum;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly SistemaAlunosDBContex _dbContext;
        public AlunoRepositorio(SistemaAlunosDBContex sistemasAlunosDbContext)
        {
            _dbContext = sistemasAlunosDbContext;
        }
        
        public async Task<List<AlunoModel>> BuscarAlunos()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<AlunoModel> BuscarAlunoPorId(int id)
        {

            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AlunoModel> BuscarAlunoPorCurso(string nomeCurso)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Nome == nomeCurso);
        }

        public async Task<AlunoModel> BuscarAlunoPorRA(int ra)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Ra == ra);
        }

        public async Task<AlunoModel> BuscarAlunoPorStatus(StatusAluno status)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Status == status);
        }

        public async Task<AlunoModel> AdicionarAluno(AlunoModel aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            _dbContext.SaveChanges();

            return aluno;
        }

        public async Task<AlunoModel> EditarAluno(AlunoModel aluno, int id)
        {
            AlunoModel alunoPorId = await BuscarAlunoPorId(id);
            if (alunoPorId == null)
            {
                throw new Exception($"O aluno com {id} não foi encontrado");
            }

            alunoPorId.Nome = aluno.Nome;
            alunoPorId.Ra = aluno.Ra;
            alunoPorId.Curso = aluno.Curso;
            alunoPorId.Foto = aluno.Foto;

            _dbContext.Alunos.Update(alunoPorId);
            _dbContext.SaveChanges();

            return alunoPorId;
        }

        public async Task<bool> ExcluirAluno(int id)
        {
            AlunoModel alunoPorId = await BuscarAlunoPorId(id);
            if (alunoPorId == null)
            {
                throw new Exception($"O aluno com {id} não foi encontrado");
            }

            _dbContext.Alunos.Remove(alunoPorId);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
