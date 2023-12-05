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
    public partial class FormAgregarMoto : FormAgregar
    {
        #region Atributos
        protected Moto nuevaMoto;
        Funciones funciones;
        #endregion

        #region Contructor
        public FormAgregarMoto()
        {
            InitializeComponent();
            this.nuevaMoto = new Moto();
            this.funciones = new Funciones();   
        }
        #endregion

        #region Botones
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {

            if (RecuperarInformacion(this.nuevaMoto))
            {
                   
                datos.AltaModificacionVehiculo(this.nuevaMoto, "INSERT");
                this.Close();
            }
               
         }
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            GuardarImagen(this.nuevaMoto);
        }
        private void FormAgregarMoto_Load(object sender, EventArgs e)
        {
            Controls.Remove(this.txtCantidadPasajeros);
            Controls.Remove(this.txtCantidadPuertas);
            Controls.Remove(this.txtCantidadEjes);
            Controls.Remove(this.txtTara);
            Controls.Remove(this.lblTara);
            Controls.Remove(this.lblEjes);
            Controls.Remove(this.lblPasajeros);
            Controls.Remove(this.lblPuertas);

            cboABS.DataSource = Enum.GetValues(typeof(eTipoDeFrenos));
            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasMotos));
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Recupera la información de una moto desde los controles del formulario y la asigna a la instancia de la moto actual.
        /// </summary>
        /// <param name="vehiculo">Instancia base del vehículo del cual se recuperará la información.</param>
        /// <remarks>
        /// Esta función sobrescribe el método base y extiende la recuperación de información para incluir propiedades específicas de las motos.
        /// La función valida la cilindrada ingresada y verifica que esté dentro del rango permitido (50-3000). Si la validación falla, se utiliza
        /// el valor por defecto 0 y se muestra un mensaje informativo.
        /// </remarks>
        /// <seealso cref="Funciones.validarNumero"/>
        /// <seealso cref="Funciones.ValidarRango"/>
        protected override bool RecuperarInformacion( Vehiculo vehiculo)
        {
            bool retorno = false;
            base.RecuperarInformacion(vehiculo);
            int cilindrada = 0;
          
            this.nuevaMoto.Marca = (eMarcasMotos)cboMarca.SelectedItem;
            this.nuevaMoto.FrenosABS = (eTipoDeFrenos)cboABS.SelectedItem;
            this.nuevaMoto.TipoVehiculo = eTipoVehiculo.Moto;

            if (funciones.validarNumero(txtCilindrada.Text, out cilindrada) && 
                Funciones.ValidarRango(cilindrada, "Rango valido (50-3000), se guardara como valor por defecto 0", "Cinlindrada", 50, 3000))
            {
                this.nuevaMoto.Cilindrada = cilindrada;
            }
            return retorno; 
        }
        #endregion
    }
}
