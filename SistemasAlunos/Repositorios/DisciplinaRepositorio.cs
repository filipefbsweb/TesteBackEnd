using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Data;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Repositorios
{
    public class DisciplinaRepositorio : IDisciplinaRepositorio
    {
        private readonly SistemaAlunosDBContex _dbContext;
        public DisciplinaRepositorio(SistemaAlunosDBContex sistemasAlunosDbContext)
        {
            _dbContext = sistemasAlunosDbContext;
        }
        public async Task<List<DisciplinaModel>> BuscarDisciplinas()
        {
            return await _dbContext.Disciplinas.ToListAsync();
        }

        public async Task<DisciplinaModel> BuscarDisciplinaPorNome(string nome)
        {
            DisciplinaModel disciplina = await _dbContext.Disciplinas.FirstOrDefaultAsync(x => x.Nome == nome);
            if (disciplina == null)
            {
                throw new Exception("Disciplina não encontrada");
            }

            return disciplina;
        }

        public async Task<DisciplinaModel> AdicionarDisciplina(DisciplinaModel disciplina)
        {
            await _dbContext.Disciplinas.AddAsync(disciplina);
            _dbContext.SaveChanges();

            return disciplina;
        }
    }
}
