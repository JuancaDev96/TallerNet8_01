using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TallerNet8.Dto;

namespace TallerNet8.Configuraciones
{
    public class CursoConfiguracion : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable(nameof(Curso));

            builder.HasData(new List<Curso>()
            {
                new () { Id = 1, Nombre = "Matematica", Profesor="Juanito Perez"},
                new () { Id = 2, Nombre = "Comunicacion", Profesor="Juanito H"},
                new () { Id = 3, Nombre = "Ingles", Profesor="Juanito Quispe"}
            });

        }
    }
}
