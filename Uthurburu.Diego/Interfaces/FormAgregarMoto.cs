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

        public FormAgregarMoto()
        {
            InitializeComponent();

            this.nuevaMoto = new Moto();
            this.datos = new AccesoDatos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion(this.nuevaMoto);
            if (Funciones.TextVacio(txtChasis))
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
        protected override void RecuperarInformacion( Vehiculo vehiculo)
        {
            base.RecuperarInformacion(vehiculo);
            int cilindrada = 0;
          
            this.nuevaMoto.Marca = (eMarcasMotos)cboMarca.SelectedItem;
            this.nuevaMoto.FrenosABS = (eTipoDeFrenos)cboABS.SelectedItem;
          
            if (Funciones.validarNumero(txtCilindrada.Text, out cilindrada) && 
                Funciones.ValidarRango(cilindrada, "Rango valido (50-3000), se guardara como valor por defecto 0", "Cinlindrada", 50, 3000))
            {
                this.nuevaMoto.Cilindrada = cilindrada;
            }

        }
        /// <summary>
        /// Recupera la información del formulario y la asigna a la instancia de la clase Moto.
        /// </summary>
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            this.nuevaMoto = GuardarImagen(this.nuevaMoto);
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
    }
}
