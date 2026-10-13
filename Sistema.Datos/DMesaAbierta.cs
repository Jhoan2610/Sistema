using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DMesaAbierta
    {
        //listar subfamilias
        public async Task<DataTable> ListarSubFamiliasAsync(int codigoPV)
        {
            // necesitamos 3 elemenos para ejecutar este metodo
            // 1. Un objeto de tipo DataTable para almacenar la tabla que traemos desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar el string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos un objeto de tipo SqlDataReader para leer los datos que nos devuelve SQL
            SqlDataReader Resultado;

            //vamos a traer los datos del punto de venta
            try
            {
                //obtener cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //crear objeto de tipo sqlCommand, para enviar la consulta a la base de datos
                SqlCommand Comando = new SqlCommand("listar_subfamilias_registro_pedidos", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo_, debemos enviarlo
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigoPV;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //ahora traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
        }

        // listar los productos pertenecinetes a una subfamilia seleccionada
        public async Task<DataTable> ListarProductosSubfamiliaAsync(int codigoPV, int codigoSF)
        {
            // necesitamos 3 elemenos para ejecutar este metodo
            // 1. Un objeto de tipo DataTable para almacenar la tabla que traemos desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar el string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos un objeto de tipo SqlDataReader para leer los datos que nos devuelve SQL
            SqlDataReader Resultado;

            //vamos a traer los datos del punto de venta
            try
            {
                //obtener cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //crear objeto de tipo sqlCommand, para enviar la consulta a la base de datos
                SqlCommand Comando = new SqlCommand("listar_productos_subfamilias", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo_, debemos enviarlo
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigoPV;
                Comando.Parameters.Add("@codigo_sf", SqlDbType.Int).Value = codigoSF;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //ahora traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
        }

        //busqueda rapida de productos
        public async Task<DataTable> BusquedaRapidaProductosAsync(string valor)
        {
            // necesitamos 3 elemenos para ejecutar este metodo
            // 1. Un objeto de tipo DataTable para almacenar la tabla que traemos desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar el string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos un objeto de tipo SqlDataReader para leer los datos que nos devuelve SQL
            SqlDataReader Resultado;
            //vamos a traer los datos del punto de venta
            try
            {
                //obtener cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //crear objeto de tipo sqlCommand, para enviar la consulta a la base de datos
                SqlCommand Comando = new SqlCommand("busqueda_rapida_producto", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo_, debemos enviarlo
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //ahora traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
        }

        //busqueda rapida cliente
        public async Task<DataTable> BusquedaRapidaCliente(string valor)
        {
            // necesitamos 3 elemenos para ejecutar este metodo
            // 1. Un objeto de tipo DataTable para almacenar la tabla que traemos desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar el string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos un objeto de tipo SqlDataReader para leer los datos que nos devuelve SQL
            SqlDataReader Resultado;
            //vamos a traer los datos del punto de venta
            try
            {
                //obtener cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //crear objeto de tipo sqlCommand, para enviar la consulta a la base de datos
                SqlCommand Comando = new SqlCommand("buscar_clientes", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo_, debemos enviarlo
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //ahora traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
        }
    }
}