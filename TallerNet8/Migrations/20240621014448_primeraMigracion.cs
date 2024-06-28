using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TallerNet8.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Profesor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoletaNotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: true),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    nota1 = table.Column<int>(type: "int", nullable: false),
                    nota2 = table.Column<int>(type: "int", nullable: false),
                    nota3 = table.Column<int>(type: "int", nullable: false),
                    promedio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoletaNotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoletaNotas_Alumno_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumno",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BoletaNotas_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alumno",
                columns: new[] { "Id", "Nivel", "Nombre" },
                values: new object[,]
                {
                    { 1, "Primaria", "Juan" },
                    { 2, "Primaria", "Miguel" },
                    { 3, "Primaria", "Luis" },
                    { 4, "Primaria", "Manuel" }
                });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "Id", "Nombre", "Profesor" },
                values: new object[,]
                {
                    { 1, "Matematica", "Juanito Perez" },
                    { 2, "Comunicacion", "Juanito H" },
                    { 3, "Ingles", "Juanito Quispe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoletaNotas_AlumnoId",
                table: "BoletaNotas",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_BoletaNotas_CursoId",
                table: "BoletaNotas",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoletaNotas");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
