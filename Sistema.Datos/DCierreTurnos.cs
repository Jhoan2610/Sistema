using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class DCierreTurnos
    {
        public async Task<string> AbrirTurnoAsync(string fechaCierreTurno, int codigoPV, int codigoTurno)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.ObtenertInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("abrir_turno", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fecha_cierre", SqlDbType.Date).Value = fechaCierreTurno;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigoPV;
                Comando.Parameters.Add("@codigo_tu", SqlDbType.Int).Value = codigoTurno;

                await SqlCon.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                Respuesta = filasAfectadas == 1 ? "OK" : "No se pudo abrir el turno";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) await SqlCon.CloseAsync();
            }

            return Respuesta;
        }

        public async Task<string> CerrarTurnoAsync(string fechaCierreTurno, int codigoPV, int codigoTurno)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.ObtenertInstancia().CrearConexion();

                SqlCommand Comando = new SqlCommand("cerrar_turno", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fecha_cierre", SqlDbType.Date).Value = fechaCierreTurno;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigoPV;
                Comando.Parameters.Add("@codigo_tu", SqlDbType.Int).Value = codigoTurno;

                await SqlCon.OpenAsync();
                int filasAfectadas = await Comando.ExecuteNonQueryAsync();
                Respuesta = filasAfectadas == 1 ? "OK" : "No se pudo cerrar el turno";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) await SqlCon.CloseAsync();
            }

            return Respuesta;
        }
    }
}