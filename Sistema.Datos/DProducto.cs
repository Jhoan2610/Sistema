using Microsoft.Data.SqlClient;
using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DProducto
    {
        //Listar los puntos de Venta
        public async Task<DataTable> Listar(string valor)
        {
            //necesitamos tres elementos para ejercutar este metodo
            //1. Un objeto de tipo Datable para almacenar la tabla que traemos de desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos objeto de tipo SqlDaraReader para leer los datos
            SqlDataReader Resultado;

            //Vamos a traer los datos del Punto de Venta
            try
            {
                //obtener la cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //Debemos crear un objeto de tipo sqlCommand para poder enviar la consulta a la BD
                SqlCommand Comando = new SqlCommand("producto_listar", sqlConnection);
                //por defecto, SQLCommand, entiende que el string es codigo de sql, debemos decirle 
                //que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado requiere un @valor, debemos enviarlo 
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el Resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
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
        //fin del metodo Listar()

        //Insertar o Actualizar un Punto de Venta
        public async Task<string> Guardar(int opcion, Producto objeto, DataTable tabla)
        {
            //necesitamos una variable para retornar el string de respuesta
            string Respuesta = "";
            //necesitamos un objeto para almacenar la cadena de conexon
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("producto_guardar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@opcion", opcion);
                Comando.Parameters.AddWithValue("@codigo", objeto.Codigo);
                Comando.Parameters.AddWithValue("@descripcion", objeto.Descripcion);
                Comando.Parameters.AddWithValue("@codigo_ma", objeto.CodigoMarca);
                Comando.Parameters.AddWithValue("@codigo_um", objeto.CodigoUnidadMedida);
                Comando.Parameters.AddWithValue("@codigo_sf", objeto.CodigoSubFamilia);
                Comando.Parameters.AddWithValue("@codigo_ad", objeto.CodigoAreaDespacho);
                Comando.Parameters.AddWithValue("@precio", objeto.PrecioUnitario);
                Comando.Parameters.AddWithValue("@observacion", objeto.Observacion);
                Comando.Parameters.AddWithValue("@imagen", objeto.Imagen);
                Comando.Parameters.AddWithValue("@tipoProductoVentaOK", tabla);
                await sqlConnection.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                Respuesta = filasAfectadas >= 1 ? "OK" : "No se pudo registrar";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                //siempre debemos cerrar nuestra conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            return Respuesta;
        }
        //Fin del metodo Guardar

        //Eliminar (ocultar) Un punto de venta
        public async Task<string> Eliminar(int id)
        {
            //necesitamos una variable para retornar el string de respuesta
            string Respuesta = "";
            //necesitamos un objeto para almacenar la cadena de conexon
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("producto_eliminar", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@codigo", id);
                await sqlConnection.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                Respuesta = filasAfectadas == 1 ? "OK" : "No se pudo registrar";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                //siempre debemos cerrar nuestra conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            return Respuesta;
        }
        //fin del metodo Eliminar

        //Determinar si un punto de Venta existe
        public async Task<string> Existe(string valor)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("producto_existe", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@valor", valor);
                //el procedimuendo almacenado no devuelve un parametro que se llama @existe
                //por ende debemos configurar esto
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
                Respuesta = ex.Message;
            }
            finally
            {
                //siempre debemos cerrar nuestra conexion a la BD
                if (sqlConnection.State == ConnectionState.Open)
                {
                    await sqlConnection.CloseAsync();
                }
            }
            return Respuesta;
        }

        //Obtener la imagen de un producto
        public async Task<byte[]> MostrarImagen(int id)
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
                SqlCommand Comando = new SqlCommand("producto_imagen_listar", sqlConnection);
                //por defecto, SQLCommand, entiende que el string es codigo de sql, debemos decirle 
                //que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado requiere un @valor, debemos enviarlo 
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = id;
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

        //Obtener la imagen por defecto de un producto
        public async Task<byte[]> MostrarImagenDefecto()
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
                SqlCommand Comando = new SqlCommand("producto_imagen_defecto_listar", sqlConnection);
                //por defecto, SQLCommand, entiende que el string es codigo de sql, debemos decirle 
                //que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
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
                throw ex;
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

        //Listar los puntos de venta
        public async Task<DataTable> ListarPuntosVenta(int opcion, int codigo)
        {
            //necesitamos tres elementos para ejercutar este metodo
            //1. Un objeto de tipo Datable para almacenar la tabla que traemos de desde SQL
            DataTable Tabla = new DataTable();
            //2. Necesitamos un objeto de tipo SqlConnection para almacenar string de conexion
            SqlConnection sqlConnection = new SqlConnection();
            //3. Necesitamos objeto de tipo SqlDaraReader para leer los datos
            SqlDataReader Resultado;

            //Vamos a traer los datos del Punto de Venta
            try
            {
                //obtener la cadena de conexion
                sqlConnection = Conexion.ObtenertInstancia().CrearConexion();
                //Debemos crear un objeto de tipo sqlCommand para poder enviar la consulta a la BD
                SqlCommand Comando = new SqlCommand("puntos_ventas_listar", sqlConnection);
                //por defecto, SQLCommand, entiende que el string es codigo de sql, debemos decirle 
                //que es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //como el procedimiento almacenado requiere un @valor, debemos enviarlo 
                Comando.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
                Comando.Parameters.Add("@codigo_pr", SqlDbType.Int).Value = codigo;
                //abrimos la conexion
                await sqlConnection.OpenAsync();
                //traemos la data
                Resultado = await Comando.ExecuteReaderAsync();
                //debemos convertir el Resultado que viene como un SqlDataReader a un DataTable
                Tabla.Load(Resultado);
                //retornamos la tabla
                return Tabla;
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