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
    public interface IZonasGeograficasServicio
    {
        [OperationContract]
        Task AddZonasGeograficasAsync(ZonasGeograficas zonaGeografica);

        [OperationContract]
        Task UpdateZonasGeograficasAsync(ZonasGeograficas zonaGeografica);

        [OperationContract]
        Task DeleteZonasGeograficasAsync(int id);

        [OperationContract]
        Task<ZonasGeograficas> GetZonasGeograficasByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<ZonasGeograficas>> GetAllZonasGeograficasAsync();
    }
}
