using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClientesRepositorioImpl : RepositorioImpl<Clientes>, IClientesRepositorio
    {
        public ClientesRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
        }
    }
}
