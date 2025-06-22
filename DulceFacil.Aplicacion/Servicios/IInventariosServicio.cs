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
    public interface IInventariosServicio
    {
        [OperationContract]
        Task AddInventariosAsync(Inventarios inventario);

        [OperationContract]
        Task UpdateInventariosAsync(Inventarios inventario);

        [OperationContract]
        Task DeleteInventariosAsync(int id);

        [OperationContract]
        Task<Inventarios> GetInventariosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Inventarios>> GetAllInventariosAsync();
    }
}
