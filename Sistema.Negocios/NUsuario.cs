using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sistema.Negocios
{
    public class NUsuario
    {
        public async static Task<DataTable> Login(string username, string password)
        {
            DUsuario Datos = new DUsuario();
            return await Datos.Login(username, password);
        }
    }
}
