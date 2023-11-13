using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WheelsHub
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                checkPassword.Text = "Ocultar";
                txtContraseña.UseSystemPasswordChar = false;
            }
            else 
            {
                checkPassword.Text = "Ver";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;

            string rutaRelativa = @"..\..\Datos\MOCK_DATA.json";
            string rutaAbsoluta = Path.GetFullPath(rutaRelativa);

            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(rutaRelativa));

            bool usuarioValido = usuarios.Any(u => u.Nombre == usuarioIngresado && u.Clave == contraseñaIngresada);

            if (usuarioValido)
            {
                FormInicio formInicio = new FormInicio();

                // Establece el nombre del usuario en el formulario FormInicio
                formInicio.NombreUsuario = usuarioIngresado;
                this.Hide();
                formInicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
