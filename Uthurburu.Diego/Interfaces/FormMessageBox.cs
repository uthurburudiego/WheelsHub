using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class FormMessageBox : Form
    {

        public FormMessageBox(string titulo, string texto)
        {
            InitializeComponent();

            this.Text = titulo;
            this.lblMensaje.Text = texto;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
