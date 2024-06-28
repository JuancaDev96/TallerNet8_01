namespace TallerNet8.Dto
{
    public class BoletaNotas
    {
        public int Id { get; set; }
        public Alumno? alumno { get; set; }
        public int? AlumnoId { get; set; }
        public Curso? curso { get; set; }
        public int CursoId { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public int nota3 { get; set; }
        public int promedio { get; set; }
    }
}
