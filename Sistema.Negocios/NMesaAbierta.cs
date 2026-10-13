using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NMesaAbierta
    {
        public static async Task<DataTable> ListarSubFamiliasAsync(int codigoPV)
        {
            DMesaAbierta Datos = new DMesaAbierta();
            return await Datos.ListarSubFamiliasAsync(codigoPV);
        }

        public static async Task<DataTable> ListarProductosSubfamiliaAsync(int codigoPV, int codigoSF)
        {
            DMesaAbierta Datos = new DMesaAbierta();
            return await Datos.ListarProductosSubfamiliaAsync(codigoPV, codigoSF);
        }

        public static async Task<DataTable> BusquedaRapidaProductosAsync(string valor)
        {
            DMesaAbierta Datos = new DMesaAbierta();
            return await Datos.BusquedaRapidaProductosAsync(valor);
        }

        public static async Task<DataTable> BusquedaRapidaCliente(string valor)
        {
            DMesaAbierta Datos = new DMesaAbierta();
            return await Datos.BusquedaRapidaCliente(valor);
        }
    }
}