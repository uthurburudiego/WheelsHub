using Entidades;
using Newtonsoft.Json.Linq;
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
    public partial class FormAgregarAuto : FormAgregar
    {
        #region Atributos
        protected Auto nuevoAuto;
        #endregion

        #region Constructor
        public FormAgregarAuto()
        {
            InitializeComponent();
            this.nuevoAuto = new Auto();

        }
        #endregion

        #region Botones
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion(this.nuevoAuto);

            if (Funciones.TextVacio(txtChasis))
            {
                if (this.nuevoAuto.Foto != null)
                {
                    datos.AltaModificacionVehiculo(this.nuevoAuto, "INSERT");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe agregar una imagen ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El campo N° de chasis es obligatorio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FormAgregarAuto_Load(object sender, EventArgs e)
        {
            Controls.Remove(this.txtCilindrada);
            Controls.Remove(this.cboABS);
            Controls.Remove(this.lblABS);
            Controls.Remove(this.lblCilindrada);
            Controls.Remove(this.txtTara);
            Controls.Remove(this.txtCantidadEjes);
            Controls.Remove(this.lblTara);
            Controls.Remove(this.lblEjes);
            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasAutos));
        }
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
             GuardarImagen(this.nuevoAuto);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Recupera la información de un auto desde los controles del formulario y la asigna a la instancia del auto actual.
        /// </summary>
        /// <param name="vehiculo">Instancia base del vehículo del cual se recuperará la información.</param>
        /// <remarks>
        /// Esta función sobrescribe el método base y extiende la recuperación de información para incluir propiedades específicas de los autos.
        /// La función valida la cantidad de pasajeros y puertas ingresadas, asegurándose de que estén dentro de los rangos permitidos (1-10 y 2-7 respectivamente).
        /// Si la validación falla, se utilizan los valores por defecto 0 y se muestra un mensaje informativo.
        /// </remarks>
        /// <seealso cref="Funciones.validarNumero"/>
        /// <seealso cref="Funciones.ValidarRango"/>
        protected override void RecuperarInformacion(Vehiculo vehiculo)
        {
            base.RecuperarInformacion (vehiculo);
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            this.nuevoAuto.Marca = (eMarcasAutos)cboMarca.SelectedItem;
            this.nuevoAuto.TipoVehiculo = eTipoVehiculo.Auto;

            if (Funciones.validarNumero(txtCantidadPasajeros.Text, out cantidadPasajeros) && 
                Funciones.ValidarRango(cantidadPasajeros, "Rango valido (1-10), se guardara como valor por defecto 0", "Cantidad de Pasajeros", 1, 10))
            {
                this.nuevoAuto.CantidadPasajeros = cantidadPasajeros;
            }
            if (Funciones.validarNumero(txtCantidadPuertas.Text, out cantidadPuertas) && 
                Funciones.ValidarRango(cantidadPuertas, "Rango valido (2-7), se guardara como valor por defecto 0", "Cantidad de Puertas", 2, 7))
            {
                this.nuevoAuto.CantidadPuertas = cantidadPuertas;
            }
          
        }
        #endregion
    }
}
