using Microsoft.EntityFrameworkCore;
using SistemasAlunos.Models;

namespace SistemasAlunos.Data.Map
{
    public class DisciplinaMap : IEntityTypeConfiguration<DisciplinaModel>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DisciplinaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NotaMinimaAprovacao).IsRequired().HasMaxLength(255);
        }
    }
}
