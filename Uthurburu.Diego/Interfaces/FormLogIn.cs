using Entidades;
using WheelsHub;
using WheelsHub.Logica;
using Newtonsoft.Json;

namespace Interfaces
{
    public partial class FormLogIn : Form
    {
        #region Atributos
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        List<string> registroUsuarios;
        #endregion

        #region Propiedades
        public Usuario Usuario { get => usuario; set => usuario = value; }
        #endregion

        #region Constructor
        public FormLogIn()
        {
            InitializeComponent();
            registroUsuarios = new List<string>();
        }
        #endregion

        #region Botones
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
            this.usuario.Correo = this.txtUsuario.Text;
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
        #endregion

        #region Metodos
        /// <summary>
        /// Valida las credenciales del usuario comparándolas con los usuarios almacenados en la lista de usuarios.
        /// </summary>
        /// <returns>Devuelve true si las credenciales son válidas y se encuentra el usuario en la lista, de lo contrario, devuelve false.</returns>
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
        #endregion 

    }
}