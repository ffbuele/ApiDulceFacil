using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Aplicacion.ServiciosImpl;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TestDulceFacilSQL
{
    public class UsuariosTests
    {
        private DulceFacilDBContext _dbContext;
        private IUsuariosServicio _usuariosServicio;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DulceFacilDBContext>()
                .UseSqlServer("")
                .Options;

            _dbContext = new DulceFacilDBContext(options);
            _usuariosServicio = new UsuariosServicioImpl(_dbContext);
        }

        [Test]
        public async Task Test1()
        {
            var rol = new Roles
            {
                Nombre="Admin",
                Descripcion="Rol administrativo de la aplicación"
            };
            

            var usuario = new Usuarios 
            { 
                NombreUsuario="ffbuele",  
                Email="pruebas@gmail.com",
                Password="12345678",
                IdRol=1
            };
            await _usuariosServicio.AddUsuariosAsync(usuario);

            var results = await _usuariosServicio.GetAllUsuariosAsync();
            Console.WriteLine(results.ToList());

            Assert.Pass();
        }

        [TearDown]
        public void Limpiar()
        {
            _dbContext.Dispose();
        }
    }
}