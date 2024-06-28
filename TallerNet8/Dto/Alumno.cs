using System.ComponentModel.DataAnnotations;

namespace TallerNet8.Dto
{
    public class Alumno
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; } = default!;
        [StringLength(30)]
        public string Nivel { get; set; } = default!;
    }
}
