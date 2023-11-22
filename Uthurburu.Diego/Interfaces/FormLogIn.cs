using Entidades;
using WheelsHub;
using WheelsHub.Logica;
using Newtonsoft.Json;

namespace Interfaces
{
    public partial class FormLogIn : Form
    {
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        List<string> registroUsuarios;

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public FormLogIn()
        {
            InitializeComponent();
            registroUsuarios = new List<string>();

        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                chkVer.Text = "Ocultar";
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                chkVer.Text = "Ver";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.usuario = new Usuario();
            this.usuario.Nombre = this.txtUsuario.Text;
            this.usuario.Clave = this.txtContraseña.Text;

            string rutaRelativa = ManejadorArchivos.ObtenerPath(@"..\..\..\..\Datos\MOCK_DATA.json");

            this.listaUsuarios = ManejadorArchivos.DeserilizarUsuarios(rutaRelativa);

            if (ValidarUsuario())
            {
                this.registroUsuarios.Add(this.usuario.Registro());
                rutaRelativa = ManejadorArchivos.ObtenerPath(@"..\..\..\..\Datos\usuarios_log.json");
                ManejadorArchivos.SerializarRegistros(registroUsuarios,rutaRelativa);

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña no existen", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarUsuario()
        {
            bool retorno = false;


            foreach (Usuario u in this.listaUsuarios)
            {
                if (u.Correo == this.usuario.Correo && u.Clave == this.usuario.Clave)
                {
                    this.usuario = u;
                    retorno = true;
                    break;
                }
            }

            return retorno;

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // El código que deseas ejecutar al presionar Enter
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true; // Evita que se procese la tecla Enter más de una vez
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // El código que deseas ejecutar al presionar Enter
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true; // Evita que se procese la tecla Enter más de una vez
            }
        }
    }
}