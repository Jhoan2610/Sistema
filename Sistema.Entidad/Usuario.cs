using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sistema.Entidad
{
    public class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public int CodigoCargo { get; set; }
        public int CodigoRol { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaUltimaSesion { get; set; }
        public bool Estado { get; set; }
    }
}
