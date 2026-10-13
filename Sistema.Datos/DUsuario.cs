using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sistema.Datos
{
    public class DUsuario
    {
        //login usuario
        public async Task<DataTable> Login(string username, string password)
        {

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
                    SqlCommand Comando = new SqlCommand("usuario_login", sqlConnection);
                    //por defecto, SqlCommand entiende que el string es codigo de sql, debemos decirle que es un procedimiento almacenado
                    Comando.CommandType = CommandType.StoredProcedure;
                    //como el procedimiento almacenado recibe un @valor, debemos enviarlo
                    Comando.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
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

}





