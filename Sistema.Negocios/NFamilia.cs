using Sistema.Datos;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocios
{
    public class NFamilia
    {
        //listar las familias
        public static async Task<DataTable> Listar(string valor)
        {
            //llamamos al metodo Listar de la clase DFamilia
            DFamilia objeto = new DFamilia();
            return await objeto.Listar(valor);
        }

        //insertar o actualizar una familia
        public static async Task<string> Guardar(int opcion, int codigo, string descripcion)
        {
            DFamilia objeto = new DFamilia();
            Familia familia = new Familia()
            {
                CodigoFA = codigo,
                DescripcionFA = descripcion
            };
            return await objeto.Guardar(opcion, familia);
        }

        //eliminar una familia
        public static async Task<string> Eliminar(int id)
        {
            DFamilia objeto = new DFamilia();
            return await objeto.Eliminar(id);
        }

        //determinar si una familia existe
        public static async Task<string> Existe(string valor)
        {
            DFamilia objeto = new DFamilia();
            return await objeto.Existe(valor);
        }
    }
}