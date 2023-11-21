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
    public partial class FormModificarAuto : FormAgregar
    {
        Auto autoModificado;
        AccesoDatos datos;
        public FormModificarAuto(Auto auto)
        {
            InitializeComponent();
            autoModificado = new Auto();
            datos = new AccesoDatos();

            MostrarInformacion(auto);

            txtChasis.Enabled = false;
            btnExaminar.Enabled = false;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RecuperarInformacion();
                if (this.autoModificado.NumeroChasis != null)
                {
                    datos.ModificarAuto(this.autoModificado);
                    this.Close();
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
        private void MostrarInformacion(Auto auto)
        {
            txtChasis.Text = auto.NumeroChasis;
            txtModelo.Text = auto.Modelo;
            cboMarca.SelectedItem = auto.Marca;
            cboColor.SelectedItem = auto.Color;
            txtCantidadPasajeros.Text = auto.CantidadPasajeros.ToString();
            txtCosto.Text = auto.Costo.ToString();
            txtCantidadPuertas.Text = auto.CantidadPuertas.ToString();
            CargarImagen(auto);

        }
        private void CargarImagen(Auto auto)
        {
            try
            {
                if (auto.Foto != null && auto.Foto.Length > 0)
                {
                    // Convierte el array de bytes a una imagen
                    using (MemoryStream ms = new MemoryStream(auto.Foto))
                    {
                        Image imagen = Image.FromStream(ms);

                        // Asigna la imagen al PictureBox
                        picImagen.Image = imagen;
                    }
                }
                else
                {
                    // Si no hay imagen, puedes asignar una imagen por defecto o dejar el PictureBox vacío
                    picImagen.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tu lógica
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }
        protected void RecuperarInformacion()
        {
            double costo = 0;
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            this.autoModificado.Modelo = txtModelo.Text;
            this.autoModificado.NumeroChasis = txtChasis.Text;
            this.autoModificado.Marca = (eMarcasAutos)cboMarca.SelectedItem;
            this.autoModificado.Color = (eColores)cboColor.SelectedItem;
            this.autoModificado.TipoVehiculo = eTipoVehiculo.Auto;


            if (validarNumero(txtCosto.Text, out costo))
            {
                this.autoModificado.Costo = costo;
            }
            if (validarNumero(txtCantidadPasajeros.Text, out cantidadPasajeros))
            {
                this.autoModificado.CantidadPasajeros = cantidadPasajeros;
            }
            if (validarNumero(txtCantidadPuertas.Text, out cantidadPuertas))
            {
                this.autoModificado.CantidadPuertas = cantidadPuertas;
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
                this.autoModificado.Foto = File.ReadAllBytes(pathImagen);

            }
        }

    }



}

