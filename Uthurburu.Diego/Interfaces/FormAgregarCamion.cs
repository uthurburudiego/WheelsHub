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

        public FormAgregarCamion()
        {
            InitializeComponent();
            this.nuevoCamion = new Camion();
            this.datos = new AccesoDatos();

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
            try
            {
                RecuperarInformacion(this.nuevoCamion);
                if (Funciones.TextVacio(txtChasis))
                {
                    if (this.nuevoCamion.Foto != null)
                    {
                        datos.AgregarCamion(this.nuevoCamion);
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
            catch (Exception ex)
            {

                MessageBox.Show($"Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }
        /// <summary>
        /// Recupera la información del formulario y la asigna a la instancia de la clase Camion.
        /// </summary>
        protected override void RecuperarInformacion( Vehiculo vehiculo)
        {
            base.RecuperarInformacion (vehiculo);
           
            int tara = 0;
            int cantidadEjes = 0;
         
            this.nuevoCamion.Marca = (eMarcasCamiones)cboMarca.SelectedItem;

            if (Funciones.validarNumero(txtTara.Text, out tara) && 
                Funciones.ValidarRango(tara, "Rango valido (mayor o igual a 0), se guardara como valor por defecto 0", "Tara", 0, 9999999999))
            {
                this.nuevoCamion.Tara = tara;
            }
            if (Funciones.validarNumero(txtCantidadEjes.Text, out cantidadEjes) && 
                Funciones.ValidarRango(cantidadEjes, "Rango valido (2-10), se guardara como valor por defecto 0", "Cantidad de Ejes", 2, 10))
            {
                this.nuevoCamion.CantidadEjes = cantidadEjes;
            }
         
        }
        /// <summary>
        /// Maneja el evento de clic en el botón "Examinar" para seleccionar una imagen y asignarla a la instancia de la clase Camion.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        protected void btnExaminar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            dlgImagen.Filter = "Archivos de imagen|*.png;*.jpg;";
            if (dlgImagen.ShowDialog() == DialogResult.OK)
            {
                string pathImagen = dlgImagen.FileName;
                picImagen.ImageLocation = pathImagen;
                this.nuevoCamion.Foto = File.ReadAllBytes(pathImagen);
            }

        }
       
    }
}
