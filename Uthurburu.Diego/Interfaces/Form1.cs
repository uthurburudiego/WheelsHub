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

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public FormLogIn()
        {
            InitializeComponent();
         
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                chkVer.Text = "Ocultar";
                txtContrase�a.UseSystemPasswordChar = false;
            }
            else
            {
                chkVer.Text = "Ver";
                txtContrase�a.UseSystemPasswordChar = true;
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
            this.usuario.Clave = this.txtContrase�a.Text;

            string rutaRelativa = ManejadorArchivos.ObtenerPath(@"..\..\..\..\Datos\MOCK_DATA.json");
            
            this.listaUsuarios = ManejadorArchivos.DeserilizarUsuarios(rutaRelativa);

            if (ValidarUsuario())
            {
                

                this.Close();
            }
            else 
            {
                MessageBox.Show("Usuario/Contrase�a no existen", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarUsuario()
        {
            bool retorno = false;
          

            foreach (Usuario u in this.listaUsuarios)
            {
                if (u.Nombre == this.usuario.Nombre && u.Clave == this.usuario.Clave)
                {
                    this.usuario = u;
                    retorno = true;
                    break;
                }
            }
            
            return retorno;

        }
    }
}