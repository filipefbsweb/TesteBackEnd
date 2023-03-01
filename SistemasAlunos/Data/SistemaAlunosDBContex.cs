using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Data.Map;
using SistemasAlunos.Models;

namespace SistemasAlunos.Data
{
    public class SistemaAlunosDBContex : DbContext 
    {
        public SistemaAlunosDBContex(DbContextOptions<SistemaAlunosDBContex> options)
            :base(options)
        {
        }

        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<CursoModel> Curso { get; set; }
        public DbSet<DisciplinaModel> Disciplinas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
