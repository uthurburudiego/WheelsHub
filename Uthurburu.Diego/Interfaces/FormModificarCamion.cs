using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelsHub;
using WheelsHub.Logica;

namespace Interfaces
{
    public partial class FormModificarCamion : FormAgregarCamion
    {

        public FormModificarCamion(Camion camion)
        {

            InitializeComponent();
            this.nuevoCamion = camion;
            txtChasis.Enabled = false;

            MostrarInformacion(camion);


        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                datos.ModificarCamion(this.nuevoCamion);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }
        protected override void MostrarInformacion(Vehiculo vehiculo)
        {
            base.MostrarInformacion(vehiculo);
            txtCantidadEjes.Text = this.nuevoCamion.CantidadEjes.ToString();
            txtTara.Text = this.nuevoCamion.Tara.ToString();    
        }
    }
}
