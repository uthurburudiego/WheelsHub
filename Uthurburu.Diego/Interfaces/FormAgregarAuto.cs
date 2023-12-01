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

        public FormAgregarAuto()
        {
            InitializeComponent();
            this.nuevoAuto = new Auto();
            this.datos = new AccesoDatos();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion(this.nuevoAuto);
            if (Funciones.TextVacio(txtChasis))
            {
                if (this.nuevoAuto.Foto != null)
                {
                    datos.AgregarAuto(this.nuevoAuto);
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
        /// <summary>
        /// Recupera la información del formulario y la asigna a la instancia de la clase Auto.
        /// </summary>
        protected override void RecuperarInformacion(Vehiculo vehiculo)
        {
            base.RecuperarInformacion (vehiculo);
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            this.nuevoAuto.Marca = (eMarcasAutos)cboMarca.SelectedItem;
     
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
        /// <summary>
        /// Maneja el evento de clic en el botón "Examinar" para seleccionar una imagen y asignarla a la instancia de la clase Auto.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            dlgImagen.Filter = "Archivos de imagen|*.png;*.jpg;";
            if (dlgImagen.ShowDialog() == DialogResult.OK)
            {
                string pathImagen = dlgImagen.FileName;
                picImagen.ImageLocation = pathImagen;
                this.nuevoAuto.Foto = File.ReadAllBytes(pathImagen);
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
    }
}
