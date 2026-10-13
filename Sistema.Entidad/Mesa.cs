using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidad
{
    public class Mesa
    {
        public int CodigoME { get; set; }
        public string DescripcionME { get; set; }
        public int CodigoPV { get; set; }
        public bool Estado { get; set; }
        public bool Disponible { get; set; } 

    }
}
