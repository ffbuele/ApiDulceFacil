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
    public interface IPuntosVentaServicio
    {
        [OperationContract]
        Task AddPuntosVentaAsync(PuntosVenta puntoVenta);

        [OperationContract]
        Task UpdatePuntosVentaAsync(PuntosVenta puntoVenta);

        [OperationContract]
        Task DeletePuntosVentaAsync(int id);

        [OperationContract]
        Task<PuntosVenta> GetPuntosVentaByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<PuntosVenta>> GetAllPuntosVentaAsync();
    }
}
