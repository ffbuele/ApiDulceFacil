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
    public interface IRolesServicio
    {
        [OperationContract]
        Task AddRolesAsync(Roles rol);

        [OperationContract]
        Task UpdateRolesAsync(Roles rol);

        [OperationContract]
        Task DeleteRolesAsync(int id);

        [OperationContract]
        Task<Roles> GetRolesByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Roles>> GetAllRolesAsync();
    }
}
