using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NSubFamilia
    {
        //listar los puntos de venta
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DMesa
            DSubFamilia objeto = new DSubFamilia();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar un punto de venta
        public static async Task<string> Guardar(int opcion, int codigo, int codigo_fa, string descripcion)
        {
            DSubFamilia objeto = new DSubFamilia();
            SubFamilia subfamilia = new SubFamilia
            {

                CodigoSF = codigo,
                CodigoFA = codigo_fa,
                DescripcionSF = descripcion
            };
            return await objeto.Guardar(opcion, subfamilia);
        }

        //eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DSubFamilia objeto = new DSubFamilia();
            return await objeto.Eliminar(id);
        }

        //determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DSubFamilia objeto = new DSubFamilia();
            return await objeto.Existe(valor);
        }
    }
}