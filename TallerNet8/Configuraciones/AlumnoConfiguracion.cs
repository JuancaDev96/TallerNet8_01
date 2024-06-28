using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerNet8.Dto;

namespace TallerNet8.Configuraciones
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable(nameof(Alumno));

            builder.HasData(new List<Alumno>()
            {
                new () { Id = 1, Nombre = "Juan", Nivel="Primaria"},
                new () { Id = 2, Nombre = "Miguel", Nivel="Primaria"},
                new () { Id = 3, Nombre = "Luis", Nivel="Primaria"},
                new () { Id = 4, Nombre = "Manuel", Nivel="Primaria"}
            });

        }
    }
}
