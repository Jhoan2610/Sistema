using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NAreaDespacho
    {
        //listar las areas de despacho
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DAreaDespacho
            DAreaDespacho objeto = new DAreaDespacho();
            return await objeto.Listar(valor);
        }
        //insertar o actualizar una area de despacho
        public static async Task<string> Guardar(int opcion, int codigo, string descripcion, string impresora)
        {
            DAreaDespacho objeto = new DAreaDespacho();
            AreaDespacho areaDespacho = new AreaDespacho()
            {
                CodigoAD = codigo,
                DescripcionAD = descripcion,
                Impresora = impresora
            };
            return await objeto.Guardar(opcion, areaDespacho);
        }
        //eliminar una area de despacho
        public static async Task<string> Eliminar(int id)
        {
            DAreaDespacho objeto = new DAreaDespacho();
            return await objeto.Eliminar(id);
        }
        //determinar si una area de despacho existe
        public static async Task<string> Existe(string valor)
        {
            DAreaDespacho objeto = new DAreaDespacho();
            return await objeto.Existe(valor);
        }
    }
}