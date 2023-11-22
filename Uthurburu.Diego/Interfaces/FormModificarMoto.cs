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
    public partial class FormModificarMoto : FormAgregarMoto
    {
        public FormModificarMoto(Moto moto)
        {
            InitializeComponent();
            this.nuevaMoto = moto;
            txtChasis.Enabled = false;
            MostrarInformacion(moto);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                datos.ModificarMoto(this.nuevaMoto);
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
            txtCilindrada.Text = this.nuevaMoto.Cilindrada.ToString();
            cboABS.SelectedItem = this.nuevaMoto.FrenosABS;
        }
    }
}
