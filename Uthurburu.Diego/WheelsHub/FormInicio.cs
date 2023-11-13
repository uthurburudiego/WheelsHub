using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelsHub
{
    public partial class FormInicio : Form
    {
        private string nombreUsuario;

       

      
        public FormInicio()
        {
            InitializeComponent();
            
        }

        public string NombreUsuario
        { 
            get { return nombreUsuario; }
            set {  nombreUsuario = value; }
        } 
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario hizo clic en "Sí" (Yes)
            if (result == DialogResult.Yes)
            {
                // Si el usuario confirma, cerrar la aplicación
                Application.Exit();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormCargarStock formCargarStock = new FormCargarStock();
            formCargarStock.Show();
           
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load_1(object sender, EventArgs e)
        {
            this.Text = "Bienvenido, " + NombreUsuario;
        }
    }
}
