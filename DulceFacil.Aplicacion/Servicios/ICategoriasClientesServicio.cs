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
    public interface ICategoriasClientesServicio
    {
        [OperationContract]
        Task AddCategoriasClientesAsync(CategoriasClientes categoriasClientes);

        [OperationContract]
        Task<bool> UpdateCategoriasClientesAsync(CategoriasClientes categoriasClientes);

        [OperationContract]
        Task DeleteCategoriasClientesAsync(int id);

        [OperationContract]
        Task<CategoriasClientes> GetCategoriasClientesByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<CategoriasClientes>> GetAllCategoriasClientesAsync();
        
        [OperationContract]
        Task<IEnumerable<CategoriasClientes>> BuscarPorNombres(string nombres);
    }
}
