using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Aplicacion.ServiciosImpl;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Leer cadena de conexion a la DB desde el archivo settings
var conexionDB = builder.Configuration.GetConnectionString("ConexionSQL");
// 2. Configuracion del DB context con la DB
builder.Services.AddDbContext<DulceFacilDBContext>(options => options.UseSqlServer(conexionDB));
// 3. Configuracion de los servicios
builder.Services.AddScoped<IRolesServicio, RolesServicioImpl>();
builder.Services.AddScoped<IUsuariosServicio, UsuariosServicioImpl>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
