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
    public partial class FormModificarAuto : FormAgregarAuto
    {
        #region Constructor
        public FormModificarAuto(Auto auto)
        {
            InitializeComponent();
            this.nuevoAuto = auto; 
        }
        #endregion

        #region Botones
        protected override void btnGuardar_Click(object sender, EventArgs e)
        {
                RecuperarInformacion( this.nuevoAuto);
                datos.ModificarAuto(this.nuevoAuto);
                this.Close();        
        }
        private void FormModificarAuto_Load(object sender, EventArgs e)
        {
            txtChasis.Enabled = false;
            MostrarInformacion(this.nuevoAuto);
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
            txtCantidadPasajeros.Text = this.nuevoAuto.CantidadPasajeros.ToString();
            txtCantidadPuertas.Text = this.nuevoAuto.CantidadPuertas.ToString();
            cboMarca.SelectedItem = this.nuevoAuto.Marca;

        }
        #endregion
    }
}
