using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos
{
    public class Conexion
    {
        //atributos para configurar la conexion a la base de datos 
        private string Servidor; // Direccion de sql server
        private string Base; // Nombre de la base de datos
        private string Usuario; // Usuario a conectar 
        private string Clave; // Clave del usuario
        private bool Seguridad; // Indica si queremos conectar con Standard Security o Trusted Connection
        private static Conexion Con = null; // Servirá para crear un singleton

        //constructor
        private Conexion()
        {
            Servidor = "Jhoan\\SQLEXPRESS";
            Base = "dbsistemapv";
            Usuario = "";
            Clave = "";
            Seguridad = true; // solo si vamos a usar trusted connection, de lo contrario poner false
        }

        //crear metodo para establecer cadena de conexion
        public SqlConnection CrearConexion()
        {
            //como debemos retornar un SQLConecction vamos a crear ese objeto
            SqlConnection Cadena = new SqlConnection(); //aqui estara el string de conexion
            try
            {
                Cadena.ConnectionString = $"Server={Servidor};Database={Base};";
                if (Seguridad)
                {
                    // nos conectamos usando trusted connection 
                    Cadena.ConnectionString += "Integrated Security=SSPI;TrustServerCertificate=True";
                }
                else
                {
                    Cadena.ConnectionString += $"User Id={Usuario};Password={Clave};TrustServerCertificate=True";
                }

            }
            catch (Exception ex)
            {
                //si hubo un error
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        //MEtodo para crear un singleton - una sola instancia de la cadena de conexion
        public static Conexion ObtenertInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;

        }
    }
}
