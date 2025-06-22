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
    public interface IProductosServicio
    {
        [OperationContract]
        Task AddProductosAsync(Productos producto);

        [OperationContract]
        Task UpdateProductosAsync(Productos producto);

        [OperationContract]
        Task DeleteProductosAsync(int id);

        [OperationContract]
        Task<Productos> GetProductosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Productos>> GetAllProductosAsync();
    }
}
