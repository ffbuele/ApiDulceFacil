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
    public interface IPedidosServicio
    {
        [OperationContract]
        Task AddPedidosAsync(Pedidos pedido);

        [OperationContract]
        Task UpdatePedidosAsync(Pedidos pedido);

        [OperationContract]
        Task DeletePedidosAsync(int id);

        [OperationContract]
        Task<Pedidos> GetPedidosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Pedidos>> GetAllPedidosAsync();
    }
}
