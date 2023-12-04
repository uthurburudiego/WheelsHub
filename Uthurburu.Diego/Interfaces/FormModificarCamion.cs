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
        #region Constructor
        public FormModificarCamion(Camion camion)
        {

            InitializeComponent();
            this.nuevoCamion = camion;

        }
        #endregion

        #region Botones
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion(this.nuevoCamion);
                datos.AltaModificacionVehiculo(this.nuevoCamion, "UPDATE");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }
        private void FormModificarCamion_Load(object sender, EventArgs e)
        {
            txtChasis.Enabled = false;

            MostrarInformacion(this.nuevoCamion);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la información del vehículo en los controles del formulario.
        /// </summary>
        /// <param name="vehiculo">Objeto de tipo Vehiculo que contiene la información a mostrar.</param>
        protected override void MostrarInformacion(Vehiculo vehiculo)
        {
            base.MostrarInformacion(vehiculo);
            txtCantidadEjes.Text = this.nuevoCamion.CantidadEjes.ToString();
            txtTara.Text = this.nuevoCamion.Tara.ToString();
            cboMarca.SelectedItem = this.nuevoCamion.Marca;
        }
        #endregion
    }
}
