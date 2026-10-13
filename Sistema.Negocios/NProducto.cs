using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NProducto
    {
        public static async Task<DataTable> Listar(string valor)
        {
            //Instanciar la capa de datos
            DProducto objeto = new DProducto();
            return await objeto.Listar(valor);
        }

        public static async Task<DataTable> ListarPuntosVenta(int opcion, int codigo)
        {
            //Instanciar la capa de datos
            DProducto objeto = new DProducto();
            return await objeto.ListarPuntosVenta(opcion, codigo);
        }

        //Insertar o Actualizar un punto de venta 
        public static async Task<string> Guardar(int opcion, Producto producto, DataTable tabla)
        {
            DProducto objeto = new DProducto();
            return await objeto.Guardar(opcion, producto, tabla);
        }

        //Eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DProducto objeto = new DProducto();
            return await objeto.Eliminar(id);
        }

        //Determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DProducto objeto = new DProducto();
            return await objeto.Existe(valor);
        }

        //Mostrar imagen de un producto
        public static async Task<byte[]> MostrarImagen(int id)
        {
            DProducto datos = new DProducto();
            return await datos.MostrarImagen(id);
        }

        //Mostrar imagen por defecto
        public static async Task<byte[]> MostrarImagenDefecto()
        {
            DProducto datos = new DProducto();
            return await datos.MostrarImagenDefecto();
        }
    }
}