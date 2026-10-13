using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidad
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CodigoMarca { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public int CodigoSubFamilia { get; set; }
        public int CodigoAreaDespacho { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; }
        public byte[] Imagen { get; set; }
    }
}
