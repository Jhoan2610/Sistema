using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NMarca
    {
        //listar los puntos de venta
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DMarca
            DMarca objeto = new DMarca();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar un punto de venta
        public static async Task<string> Guardar(int opcion, int codigo, string descripcion)
        {
            DMarca objeto = new DMarca();
            Marca marca = new Marca()
            {
                CodigoMA = codigo,
                DescripcionMA = descripcion
            };
            return await objeto.Guardar(opcion, marca);
        }

        //eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DMarca objeto = new DMarca();
            return await objeto.Eliminar(id);
        }

        //determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DMarca objeto = new DMarca();
            return await objeto.Existe(valor);
        }
    }
}