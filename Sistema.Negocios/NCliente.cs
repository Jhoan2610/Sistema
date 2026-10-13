using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NCliente
    {
        public static async Task<DataTable> Listar(string valor)
        {
            //Instanciar la capa de datos
            DCliente objeto = new DCliente();
            return await objeto.Listar(valor);
        }

        public static async Task<DataTable> ListarTipoDocAsync()
        {
            //Instanciar la capa de datos
            DCliente objeto = new DCliente();
            return await objeto.ListarTipoDocAsync();
        }

        //Insertar o Actualizar un punto de venta 
        public static async Task<string> Guardar(int opcion, Cliente cliente)
        {
            DCliente objeto = new DCliente();
            return await objeto.Guardar(opcion, cliente);
        }

        //Eliminar un punto de venta
        public static async Task<string> Eliminar(int id)
        {
            DCliente objeto = new DCliente();
            return await objeto.Eliminar(id);
        }

        //Determinar si un punto de venta existe
        public static async Task<string> Existe(string valor)
        {
            DCliente objeto = new DCliente();
            return await objeto.Existe(valor);
        }

    }
}