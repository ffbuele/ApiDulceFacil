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
    public interface IClientesServicio
    {
        [OperationContract]
        Task AddClientesAsync(Clientes cliente);

        [OperationContract]
        Task UpdateClientesAsync(Clientes cliente);

        [OperationContract]
        Task DeleteClientesAsync(int id);

        [OperationContract]
        Task<Clientes> GetClientesByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Clientes>> GetAllClientesAsync();
    }
}
