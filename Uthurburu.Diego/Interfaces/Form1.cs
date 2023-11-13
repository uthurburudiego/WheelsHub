namespace Interfaces
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
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
            string usuario = this.txtUsuario.Text;
            string constraseña = this.txtContraseña.Text;

            if (usuario == "Kira" && constraseña == "123")
            {

            }

            else
            {
                MessageBox.Show("El Usuario/Clave incorrecta", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}