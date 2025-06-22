using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuariosRepositorioImpl : RepositorioImpl<Usuarios>, IUsuariosRepositorio
    {
        public UsuariosRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
        }
    }
}
