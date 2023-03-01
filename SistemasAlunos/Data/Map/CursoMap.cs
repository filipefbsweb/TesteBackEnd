using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Models;

namespace SistemasAlunos.Data.Map
{
    public class CursoMap : IEntityTypeConfiguration<CursoModel>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CursoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.HasMany(x => x.Disciplinas);
        }
    }
}
