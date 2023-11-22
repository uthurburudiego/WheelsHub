using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelsHub.Logica;

namespace Interfaces
{
    public partial class FormModificarAuto : FormAgregarAuto
    {
        public FormModificarAuto(Auto auto)
        {
            InitializeComponent();
            this.nuevoAuto = auto;
            txtChasis.Enabled = false;
            MostrarInformacion(auto);
        }
        protected override void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                datos.ModificarAuto(this.nuevoAuto);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }

        }
    }
}
