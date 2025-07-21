using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RolesRepositorioImpl : RepositorioImpl<Roles>, IRolesRepositorio
    {
        private readonly DulceFacilDBContext _dbContext;

        public RolesRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
