using Sistema.Entidad;
using Sistema.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Sistema.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async Task MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo para hacer el login
        private async Task Login(string username, string password)
        {
            try
            {
                var tabla = await NUsuario.Login(username, password);
                if (tabla.Rows.Count > 0)
                {
                    // usuario existe y esta acitvo
                    Usuario usuario = new Usuario()
                    {
                        CodigoUsuario = Convert.ToInt32(tabla.Rows[0][0]),
                        Username = tabla.Rows[0][1].ToString(),
                        Nombre = tabla.Rows[0][2].ToString(),
                        CodigoCargo = Convert.ToInt32(tabla.Rows[0][4]),
                        CodigoRol = Convert.ToInt32(tabla.Rows[0][5]),

                    };
                    //ese usuario hay que pasarlo al frm principal
                    FrmDashBoard frm = new FrmDashBoard();
                    frm.Usuario = usuario;
                    frm.DescripcionCargo = tabla.Rows[0][3].ToString();
                    frm.DescripcionRol = tabla.Rows[0][6].ToString();
                    frm.Show();

                    //vamos a inscribir un eventhandle que permita hacer el logout si se cierra el frm principal
                    frm.FormClosed += Logout;


                    //ocultamos form de login
                    this.Hide();
                }
                else
                {
                    //usuario no existe o esta inactivo
                    await MensajeError("Inicio de sesion incorrecto");
                }
            }
            catch (Exception ex)
            {

                MensajeError(ex.Message);
            }
        }

        //cerrar sesion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            this.Show();
            TxtUsername.Focus();
        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                await MensajeError("Complete todos los campos");
                return;
            }
            else
            {
                await Login(TxtUsername.Text.Trim(), TxtPassword.Text.Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
