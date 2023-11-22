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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                if (this.nuevoAuto.NumeroChasis != null)
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
            catch (Exception ex)
            {

                MessageBox.Show($"Debe completar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            

        }
        protected  void RecuperarInformacion()
        {
            double costo = 0;
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            this.nuevoAuto.Modelo = txtModelo.Text;
            this.nuevoAuto.NumeroChasis = txtChasis.Text;
            this.nuevoAuto.Marca = (eMarcasAutos)cboMarca.SelectedItem;
            this.nuevoAuto.Color = (eColores)cboColor.SelectedItem;
            this.nuevoAuto.TipoVehiculo = eTipoVehiculo.Auto;
        

            if (Funciones.validarNumero(txtCosto.Text, out costo))
            {
                this.nuevoAuto.Costo = costo;
            }
            if (Funciones.validarNumero(txtCantidadPasajeros.Text, out cantidadPasajeros))
            {
                this.nuevoAuto.CantidadPasajeros = cantidadPasajeros;
            }
            if (Funciones.validarNumero(txtCantidadPuertas.Text, out cantidadPuertas))
            {
                this.nuevoAuto.CantidadPuertas = cantidadPuertas;
            }
          
        }
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
    }
}
