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
                RecuperarInformacion();
                if (this.nuevoCamion.NumeroChasis != null)
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

        protected void RecuperarInformacion()
        {
            double costo = 0;
            int tara = 0;
            int cantidadEjes = 0;
            this.nuevoCamion.TipoVehiculo = eTipoVehiculo.Camion;
            this.nuevoCamion.Modelo = txtModelo.Text;
            this.nuevoCamion.NumeroChasis = txtChasis.Text;
            this.nuevoCamion.Marca = (eMarcasCamiones)cboMarca.SelectedItem;
            this.nuevoCamion.Color = (eColores)cboColor.SelectedItem;

            if (Funciones.validarNumero(txtCosto.Text, out costo))
            {
                this.nuevoCamion.Costo = costo;
            }
            if (Funciones.validarNumero(txtTara.Text, out tara))
            {
                this.nuevoCamion.Tara = tara;
            }
            if (Funciones.validarNumero(txtCantidadEjes.Text, out cantidadEjes))
            {
                this.nuevoCamion.CantidadEjes = cantidadEjes;
            }
         
        }

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
