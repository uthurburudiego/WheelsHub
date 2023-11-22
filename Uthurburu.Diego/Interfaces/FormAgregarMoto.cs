using Entidades;
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
    public partial class FormAgregarMoto : FormAgregar
    {
     
        public FormAgregarMoto()
        {
            InitializeComponent();

            this.nuevaMoto = new Moto();
            this.datos = new AccesoDatos();


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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                if (this.nuevaMoto.NumeroChasis != null)
                {
                    if (this.nuevaMoto.Foto != null)
                    {
                        datos.AgregarMoto(this.nuevaMoto);
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
            catch (Exception)
            {

                throw new ExcepcionDatosInvalidos("Debe completar los campos.");
            }
        }
        protected void RecuperarInformacion()
        {
            double costo = 0;
            int cilindrada = 0;
            this.nuevaMoto.TipoVehiculo = eTipoVehiculo.Moto;
            this.nuevaMoto.NumeroChasis = txtChasis.Text;
            this.nuevaMoto.Modelo = txtModelo.Text;
            this.nuevaMoto.Marca = (eMarcasMotos)cboMarca.SelectedItem;
            this.nuevaMoto.Color = (eColores)cboColor.SelectedItem;
            this.nuevaMoto.FrenosABS = (eTipoDeFrenos)cboABS.SelectedItem;
            if (Funciones.validarNumero(txtCosto.Text, out costo))
            {
                this.nuevaMoto.Costo = costo;
            }
            if (Funciones.validarNumero(txtCilindrada.Text, out cilindrada))
            {
                this.nuevaMoto.Cilindrada = cilindrada;
            }
           
        }
        /// <summary>
        /// Recupera la información del formulario y la asigna a la instancia de la clase Moto.
        /// </summary>
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            this.nuevaMoto = GuardarImagen( this.nuevaMoto);
        }
        /// <summary>
        /// Maneja el evento de clic en el botón "Examinar" para seleccionar una imagen y asignarla a la instancia de la clase Moto.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        protected Moto GuardarImagen(Moto moto)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            dlgImagen.Filter = "Archivos de imagen|*.png;*.jpg;";
            if (dlgImagen.ShowDialog() == DialogResult.OK)
            {
                string pathImagen = dlgImagen.FileName;
                picImagen.ImageLocation = pathImagen;
                moto.Foto = File.ReadAllBytes(pathImagen);

            }
            return moto;
        }
    }
}
