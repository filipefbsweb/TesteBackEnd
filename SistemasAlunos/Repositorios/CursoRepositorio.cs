using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Data;
using SistemasAlunos.Models;
using SistemasAlunos.Repositorios.Interfaces;

namespace SistemasAlunos.Repositorios
{
    public class CursoRepositorio : ICursoRepositorio
    {
        private readonly SistemaAlunosDBContex _dbContext;
        public CursoRepositorio(SistemaAlunosDBContex sistemasAlunosDbContext)
        {
            _dbContext = sistemasAlunosDbContext;
        }
        public async Task<List<CursoModel>> BuscarCursos()
        {
            return await _dbContext.Curso.ToListAsync();
        }

        public async Task<CursoModel> BuscarCursoPorNome(string nome)
        {
            return await _dbContext.Curso.FirstOrDefaultAsync(x => x.Nome == nome);
        }

        public async Task<CursoModel> AdicionarNovoCurso([FromBody] CursoModel curso)
        {
            await _dbContext.Curso.AddAsync(curso);
            _dbContext.SaveChanges();

            return curso;

        }
    }
}
