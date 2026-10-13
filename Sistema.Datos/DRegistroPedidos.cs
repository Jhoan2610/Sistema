using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DRegistroPedidos
    {
        public async Task<DataTable> EstadoTurnoPuntoVenta(int codigo)
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
                SqlCommand Comando = new SqlCommand("estado_turno_pv", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo, debemos enviarlo
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
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

        }// fi

        public async Task<DataTable> MostrarMesas(int codigo)
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
                SqlCommand Comando = new SqlCommand("mostrar_mesas", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @codigo, debemos enviarlo
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigo;
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

        public async Task<byte[]> ImagenEstadoMesa(int id)
        {
            //necesitamos tres elementos para ejercutar este metodo
            //1. Un objeto de tipo Datable para almacenar la tabla que traemos de desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos objeto de tipo SqlDaraReader para leer los datos
            SqlDataReader Resultado;
            Byte[] Imagen = new byte[0];

            //Vamos a traer los datos del Punto de Venta
            try
            {
                //obtener la cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //Debemos crear un objeto de tipo sqlCommand para poder enviar la consulta a la BD
                SqlCommand Comando = new SqlCommand("imagen_estado_mesas", sqlConnection);
                //por defecto, SQLCommand, entiende que el string es codigo de sql, debemos decirle 
                //que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado requiere un @valor, debemos enviarlo 
                Comando.Parameters.Add("@estado", SqlDbType.Int).Value = id;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el Resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                Imagen = Tabla.Rows[0][0] as byte[];
                return Imagen;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                //siempre debemos cerrar nuestra conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
        }
    }
}