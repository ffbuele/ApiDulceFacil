﻿using DulceFacil.Aplicacion.DTO.DTOs;
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
    public interface IUsuariosServicio
    {
        [OperationContract]
        Task AddUsuariosAsync(Usuarios usuario);

        [OperationContract]
        Task<bool> UpdateUsuariosAsync(UsuarioDTO usuario);

        [OperationContract]
        Task DeleteUsuariosAsync(int id);

        [OperationContract]
        Task<Usuarios> GetUsuariosByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Usuarios>> GetAllUsuariosAsync();

        [OperationContract]
        Task<List<UsuarioDTO>> GetUsuariosRoles();
        
        [OperationContract]
        Task<List<UsuarioDTO>> UsuariosPorNombres(string nombres);
    }
}
