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
    public interface ICategoriasProductosServicio
    {
        [OperationContract]
        Task AddCategoriasProductosAsync(CategoriasProductos categoriaProducto);

        [OperationContract]
        Task UpdateCategoriasProductosAsync(CategoriasProductos categoriaProduct);

        [OperationContract]
        Task DeleteCategoriasProductosAsync(int id);

        [OperationContract]
        Task<CategoriasProductos> GetCategoriasProductosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<CategoriasProductos>> GetAllCategoriasProductosAsync();
    }
}
