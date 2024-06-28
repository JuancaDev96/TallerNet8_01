using Microsoft.EntityFrameworkCore;
using TallerNet8.Contexto;
using TallerNet8.Dto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TallerNet8DBContext>(options =>
{
    var conexion = builder.Configuration.GetConnectionString("TallerNet8");
    options.UseSqlServer(conexion);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("api/Alumnos", async (TallerNet8DBContext contexto) =>
{
    var resultado = await contexto.Set<Alumno>()
    .AsNoTracking()
    .ToListAsync();
    return Results.Ok(resultado);
});

app.MapGet("api/Cursos", async (TallerNet8DBContext contexto) =>
{
    var resultado = await contexto.Set<Curso>()
    .AsNoTracking()
    .ToListAsync();
    return Results.Ok(resultado);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
