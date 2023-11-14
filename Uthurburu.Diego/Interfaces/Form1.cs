using Entidades;
using WheelsHub;
using WheelsHub.Logica;

namespace Interfaces
{
    public partial class FormLogIn : Form
    {
        private bool acceso;
        private string usuario;
        private string contrase�a;
        private List<Usuario> listaUsuarios;
        private AccesoDatos datosUsuarios;

        public bool Acceso { get => acceso; set => acceso = value; }

        public FormLogIn(bool acceso = false)
        {
            InitializeComponent();
            this.acceso = false;
            this.acceso = acceso;
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
            this.usuario = this.txtUsuario.Text;
            this.contrase�a = this.txtContrase�a.Text;
            this.datosUsuarios = new AccesoDatos();

            this.listaUsuarios = datosUsuarios.ObtenerListaDatos();


            if (this.ValidarUsuario())
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("El Usuario/Clave incorrecta", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarUsuario()
        {
            bool retorno = false;

            foreach (Usuario u in this.listaUsuarios)
            {
                if (u.Nombre == this.usuario)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }
    }
}