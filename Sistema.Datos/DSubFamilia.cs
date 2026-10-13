using Microsoft.Data.SqlClient;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DSubFamilia
    {
        // LIstar las mesas
        public async Task<DataTable> Listar(string valor)
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
                SqlCommand Comando = new SqlCommand("subfamilia_listar", sqlConnection);
                //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado recibe un @valor, debemos enviarlo
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
        }// fin del metodo Listar()

        //insertar o actualizar un punto de venta
        public async Task<string> Guardar(int opcion, SubFamilia objeto)
        {
            //necesitamos una variable para retornar el string de respuesta
            string respuesta = "";
            //necesitamos un objeto para almacenar cadenas de conexion
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("subfamilia_guardar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@opcion", opcion);
                Comando.Parameters.AddWithValue("@codigo", objeto.CodigoSF);
                Comando.Parameters.AddWithValue("@codigo_familia", objeto.CodigoFA);
                Comando.Parameters.AddWithValue("@descripcion", objeto.DescripcionSF);
                await sqlConnection.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                respuesta = filasAfectadas == 1 ? "OK" : "No se pudo registrar";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message; // represtancion en string de excepcion
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            //retornamos la respuesta
            return respuesta;
        } //fin de Guardar()

        //eliminar un punto de venta
        public async Task<string> Eliminar(int id)
        {
            //necesitamos una variable para retornar el string de respuesta
            string respuesta = "";
            //necesitamos un objeto para almacenar cadenas de conexion
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("subfamilia_eliminar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codigo", id);
                await sqlConnection.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                respuesta = filasAfectadas == 1 ? "OK" : "No se pudo eliminar";
            }
            catch (Exception ex)
            {

                respuesta = ex.Message; // represtancion en string de excepcion
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            //retornamos la respuesta
            return respuesta;
        } // fin eliminar()

        public async Task<string> Existe(string valor)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("subfamilia_existe", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@valor", valor);
                //el procedimiento almacenado nos devuelve un parametro que se llama @existe, por ende debemos configurarlo
                SqlParameter Existe = new SqlParameter();
                Existe.ParameterName = "@existe";
                Existe.SqlDbType = SqlDbType.Int;
                Existe.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(Existe);
                await sqlConnection.OpenAsync();
                await Comando.ExecuteNonQueryAsync();
                Respuesta = Convert.ToString(Existe.Value)!;
            }
            catch (Exception ex)
            {

                Respuesta = ex.Message; // represtancion en string de excepcion
            }
            finally
            {
                // siempre debemos cerrar la conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            return Respuesta;
        }
    }
}