using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Models;

namespace SistemasAlunos.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<AlunoModel>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AlunoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Ra).IsRequired().HasMaxLength(255);
            builder.HasOne(x => x.Curso);
        }
    }
}
