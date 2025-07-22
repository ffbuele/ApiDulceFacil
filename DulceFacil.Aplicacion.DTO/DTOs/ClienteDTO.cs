using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.DTO.DTOs
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string TipoIdentificacion { get; set; }

        public string Identificacion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public double? Latitud { get; set; }

        public double? Longitud { get; set; }

        public int IdCategoriaCliente { get; set; }
        public string? NombreCategoriaCliente { get; set; }

        public int? IdZonaGeografica { get; set; }
        public string? NombreZonaGeografica { get; set; }

        public string Estado { get; set; }

    }
}
