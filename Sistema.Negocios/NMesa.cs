using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NMesa
    {
        //listar los puntos de venta
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DMesa
            DMesa objeto = new DMesa();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar un punto de venta
        public static async Task<string> Guardar(int opcion, int codigo, int codigo_pv, string descripcion, int disponible)
        {
            DMesa objeto = new DMesa();
            Mesa mesa = new Mesa
            {

                CodigoME = codigo,
                CodigoPV = codigo_pv,
                DescripcionME = descripcion,
                Disponible = disponible == 1
            };
            return await objeto.Guardar(opcion, mesa);
        }

        //eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DMesa objeto = new DMesa();
            return await objeto.Eliminar(id);
        }

        //determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DMesa objeto = new DMesa();
            return await objeto.Existe(valor);
        }

        //metodo para cambiar el estado disponible
        public static async Task<string> DisponibleAsync(int id, int estadoDisponible)
        {
            DMesa objeto = new DMesa();
            return await objeto.DisponibleAsync(id, estadoDisponible);
        }
    }
}