using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NUnidadesMedida
    {
        //listar los puntos de venta
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DMarca
            DUnidadesMedida objeto = new DUnidadesMedida();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar un punto de venta
        public static async Task<string> Guardar(int opcion, int codigo, string descripcion)
        {
            DUnidadesMedida objeto = new DUnidadesMedida();
            UnidadesMedida unidad = new UnidadesMedida()
            {
                CodigoUM = codigo,
                DescripcionUM = descripcion
            };
            return await objeto.Guardar(opcion, unidad);
        }

        //eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DUnidadesMedida objeto = new DUnidadesMedida();
            return await objeto.Eliminar(id);
        }

        //determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DUnidadesMedida objeto = new DUnidadesMedida();
            return await objeto.Existe(valor);
        }
    }
}