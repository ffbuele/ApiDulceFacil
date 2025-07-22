using DulceFacil.Aplicacion.DTO.DTOs;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Dominio.Modelos.Abstracciones
{
    public interface IClientesRepositorio : IRepositorio<Clientes>
    {
        public Task<List<ClienteDTO>> GetClientesDetalles();
        public Task<List<ClienteDTO>> ClientesPorNombres(string nombres);
    }
}
