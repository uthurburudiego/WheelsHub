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
            string usuario = this.txtUsuario.Text;
            string constrase�a = this.txtContrase�a.Text;

            if (usuario == "Kira" && constrase�a == "123")
            {

            }

            else
            {
                MessageBox.Show("El Usuario/Clave incorrecta", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}