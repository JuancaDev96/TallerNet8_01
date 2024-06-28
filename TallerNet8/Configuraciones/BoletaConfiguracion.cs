using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerNet8.Dto;

namespace TallerNet8.Configuraciones
{
    public class BoletaConfiguracion : IEntityTypeConfiguration<BoletaNotas>
    {
        public void Configure(EntityTypeBuilder<BoletaNotas> builder)
        {
            builder.ToTable(nameof(BoletaNotas));
        }
    }
}
