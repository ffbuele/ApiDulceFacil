using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Servicios
{
    [ServiceContract]
    public interface IDetallesPedidosServicio
    {
        [OperationContract]
        Task AddDetallesPedidosAsync(DetallesPedidos detallePedido);

        [OperationContract]
        Task UpdateDetallesPedidosAsync(DetallesPedidos detallePedido);

        [OperationContract]
        Task DeleteDetallesPedidosAsync(int id);

        [OperationContract]
        Task<DetallesPedidos> GetDetallesPedidosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<DetallesPedidos>> GetAllDetallesPedidosAsync();
    }
}
