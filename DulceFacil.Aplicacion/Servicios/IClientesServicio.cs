using DulceFacil.Aplicacion.DTO.DTOs;
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
        Task AddClientesAsync(ClienteDTO cliente);

        [OperationContract]
        Task<bool> UpdateClientesAsync(ClienteDTO cliente);

        [OperationContract]
        Task DeleteClientesAsync(int id);

        [OperationContract]
        Task<Clientes> GetClientesByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<ClienteDTO>> GetAllClientesAsync();

        [OperationContract]
        Task<IEnumerable<ClienteDTO>> BuscarPorNombres(string nombres);
    }
}
