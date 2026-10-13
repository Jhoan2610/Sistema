using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;

namespace Sistema.Negocios
{
    public class NCierreTurnos
    {
        public static async Task<string> AbrirTurnoAsync(string fecha, int codigoPV, int codigoTurno)
        {
            DCierreTurnos datos = new DCierreTurnos();
            return await datos.AbrirTurnoAsync(fecha, codigoPV, codigoTurno);
        }

        public static async Task<string> CerrarTurnoAsync(string fecha, int codigoPV, int codigoTurno)
        {
            DCierreTurnos datos = new DCierreTurnos();
            return await datos.CerrarTurnoAsync(fecha, codigoPV, codigoTurno);
        }
    }
}