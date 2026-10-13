using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NPuntoVenta
    {
        //listar los puntos de venta
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DPuntoVenta
            DPuntoVenta objeto = new DPuntoVenta();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar un punto de venta
        public static async Task<string> Guardar(int opcion, int codigo, string descripcion)
        {
            DPuntoVenta objeto = new DPuntoVenta();
            PuntoVenta puntoventa = new PuntoVenta()
            {
                CodigoPV = codigo,
                DescripcionPV = descripcion
            };
            return await objeto.Guardar(opcion, puntoventa);
        }

        //eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DPuntoVenta objeto = new DPuntoVenta();
            return await objeto.Eliminar(id);
        }

        //determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DPuntoVenta objeto = new DPuntoVenta();
            return await objeto.Existe(valor);
        }
    }
}