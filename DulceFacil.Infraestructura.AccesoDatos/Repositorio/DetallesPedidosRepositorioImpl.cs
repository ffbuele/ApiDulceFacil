using DulceFacil.Dominio.Modelos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class DetallesPedidosRepositorioImpl : RepositorioImpl<DetallesPedidos>, IDetallerPedidosRepositorio
    {
        public DetallesPedidosRepositorioImpl(DulceFacilDBContext context) : base(context)
        {
        }
    }
}
