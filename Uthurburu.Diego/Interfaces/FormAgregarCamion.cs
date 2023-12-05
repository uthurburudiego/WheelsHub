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
    public partial class FormAgregarCamion : FormAgregar
    {
        #region Atributos
        protected Camion nuevoCamion;
        Funciones funciones;
        #endregion

        #region Constructor
        public FormAgregarCamion()
        {
            InitializeComponent();
            this.nuevoCamion = new Camion(); 
            this.funciones = new Funciones();
        }

        #endregion

        #region Botones
        private void FormAgregarCamion_Load(object sender, EventArgs e)
        {
            Controls.Remove(this.txtCantidadPasajeros);
            Controls.Remove(this.txtCantidadPuertas);
            Controls.Remove(this.lblPasajeros);
            Controls.Remove(this.lblPuertas);
            Controls.Remove(this.txtCilindrada);
            Controls.Remove(this.cboABS);
            Controls.Remove(this.lblABS);
            Controls.Remove(this.lblCilindrada);

            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasCamiones));
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            if (funciones.TextVacio(txtChasis))
            {
                if (picImagen.Image != null)
                {
                    RecuperarInformacion(this.nuevoCamion);
                    datos.AltaModificacionVehiculo(this.nuevoCamion, "INSERT");
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
        protected void btnExaminar_Click_1(object sender, EventArgs e)
        {

            GuardarImagen(this.nuevoCamion);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Recupera la información de un camión desde los controles del formulario y la asigna a la instancia del camión actual.
        /// </summary>
        /// <param name="vehiculo">Instancia base del vehículo del cual se recuperará la información.</param>
        /// <remarks>
        /// Esta función sobrescribe el método base y extiende la recuperación de información para incluir propiedades específicas de los camiones.
        /// La función valida la tara y la cantidad de ejes ingresados, asegurándose de que estén dentro de los rangos permitidos (mayor o igual a 0 y 2-10 respectivamente).
        /// Si la validación falla, se utilizan los valores por defecto 0 y se muestra un mensaje informativo.
        /// </remarks>
        /// <seealso cref="Funciones.validarNumero"/>
        /// <seealso cref="Funciones.ValidarRango"/>
        protected override bool RecuperarInformacion(Vehiculo vehiculo)
        {
            bool retorno = false;   
            base.RecuperarInformacion(vehiculo);

            int tara = 0;
            int cantidadEjes = 0;

            this.nuevoCamion.Marca = (eMarcasCamiones)cboMarca.SelectedItem;
            this.nuevoCamion.TipoVehiculo = eTipoVehiculo.Camion;

            if (funciones.validarNumero(txtTara.Text, out tara) &&
                Funciones.ValidarRango(tara, "Rango valido (mayor o igual a 0), se guardara como valor por defecto 0", "Tara", 0, 9999999999))
            {
                this.nuevoCamion.Tara = tara;
            }
            if (funciones.validarNumero(txtCantidadEjes.Text, out cantidadEjes) &&
                Funciones.ValidarRango(cantidadEjes, "Rango valido (2-10), se guardara como valor por defecto 0", "Cantidad de Ejes", 2, 10))
            {
                this.nuevoCamion.CantidadEjes = cantidadEjes;
            }
            return retorno;
        }
        #endregion
    }
}
