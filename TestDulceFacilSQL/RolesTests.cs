using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Aplicacion.ServiciosImpl;
using DulceFacil.Infraestructura.AccesoDatos;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TestDulceFacilSQL
{
    public class RolesTests
    {
        private DulceFacilDBContext _dbContext;
        private IRolesServicio _rolesServicio;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DulceFacilDBContext>()
                .UseSqlServer("Data Source=ffbuele\\MSSQLSERVER01;Initial Catalog=DulceFacilDB;Integrated Security=True;TrustServerCertificate=true;")
                .Options;

            _dbContext = new DulceFacilDBContext(options);
            _rolesServicio = new RolesServicioImpl(_dbContext);
        }

        [Test]
        public async Task Test1()
        {
            var rol = new Roles
            {
                Nombre="Admin",
                Descripcion="Rol administrativo de la aplicación"
            };

            await _rolesServicio.AddRolesAsync(rol);

            var results = await _rolesServicio.GetAllRolesAsync();
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