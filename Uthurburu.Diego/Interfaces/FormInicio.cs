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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void radAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radAuto.Checked)
            {
                this.BackgroundImage = Properties.Resources.fondoAuto1;
            }
        }

        private void radMoto_CheckedChanged(object sender, EventArgs e)
        {
            if (radMoto.Checked)
            {
                this.BackgroundImage = Properties.Resources.fondoMoto;
            }
        }

        private void radCamion_CheckedChanged(object sender, EventArgs e)
        {
            if (radCamion.Checked)
            {
                this.BackgroundImage = Properties.Resources.fondoCamion;
            }
        }
    }
}
