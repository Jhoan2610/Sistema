using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidad
{
    public class Cliente
    {
        public int CodigoCl { get; set; }
        public int CodigoTdc { get; set; }
        public string NumDocumentoCl { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public string DescripcionTdc { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
