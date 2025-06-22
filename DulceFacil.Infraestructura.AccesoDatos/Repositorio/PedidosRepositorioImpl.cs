using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class PedidosRepositorioImpl : RepositorioImpl<Pedidos>, IPedidosRepositorio
    {
        public PedidosRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
        }
    }
}
