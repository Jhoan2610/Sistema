using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NRegistroPedidos
    {
        public static async Task<DataTable> EstadoTurnoPuntoVenta(int codigo)
        {
            DRegistroPedidos datos = new DRegistroPedidos();
            return await datos.EstadoTurnoPuntoVenta(codigo);
        }

        public static async Task<DataTable> MostrarMesas(int codigo)
        {
            DRegistroPedidos datos = new DRegistroPedidos();
            return await datos.MostrarMesas(codigo);
        }

        public static async Task<byte[]> ImagenEstadoMesa(int codigo)
        {
            DRegistroPedidos datos = new DRegistroPedidos();
            return await datos.ImagenEstadoMesa(codigo);
        }
    }
}