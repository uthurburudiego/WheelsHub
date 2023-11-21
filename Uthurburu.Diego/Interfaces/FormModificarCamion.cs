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
    public partial class FormModificarCamion : FormAgregar
    {
        Camion camionModificado;
        AccesoDatos datos;
        public FormModificarCamion(Camion camion)
        {
            InitializeComponent();
            camionModificado = new Camion();
            datos = new AccesoDatos();

            MostrarInformacion(camion);


            txtChasis.Enabled = false;
            lblTitulo.Text = "Modificar Camion";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
            if (datos.ModificarCamion(this.camionModificado))
            {
                MessageBox.Show("Se modifico con EXITO!!!", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se realizo la modificacion", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void MostrarInformacion(Camion camion)
        {
            txtChasis.Text = camion.NumeroChasis;
            txtModelo.Text = camion.Modelo;
            cboMarca.SelectedItem = camion.Marca;
            cboColor.SelectedItem = camion.Color;
            txtCantidadEjes.Text = camion.CantidadEjes.ToString();
            txtCosto.Text = camion.Costo.ToString();
            txtTara.Text = camion.Tara.ToString();
            CargarImagen(camion);

        }

        private void CargarImagen(Camion camion)
        {
            try
            {
                if (camion.Foto != null && camion.Foto.Length > 0)
                {
                    // Convierte el array de bytes a una imagen
                    using (MemoryStream ms = new MemoryStream(camion.Foto))
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            dlgImagen.Filter = "Archivos de imagen|*.png;*.jpg;";
            if (dlgImagen.ShowDialog() == DialogResult.OK)
            {
                string pathImagen = dlgImagen.FileName;
                picImagen.ImageLocation = pathImagen;
                this.camionModificado.Foto = File.ReadAllBytes(pathImagen);

            }
        }
        protected void RecuperarInformacion()
        {
            double costo = 0;
            int tara = 0;
            int cantidadEjes = 0;
            this.camionModificado.TipoVehiculo = eTipoVehiculo.Camion;
            this.camionModificado.Modelo = txtModelo.Text;
            this.camionModificado.NumeroChasis = txtChasis.Text;
            this.camionModificado.Marca = (eMarcasCamiones)cboMarca.SelectedItem;
            this.camionModificado.Color = (eColores)cboColor.SelectedItem;

            if (validarNumero(txtCosto.Text, out costo))
            {
                this.camionModificado.Costo = costo;
            }
            if (validarNumero(txtTara.Text, out tara))
            {
                this.camionModificado.Tara = tara;
            }
            if (validarNumero(txtCantidadEjes.Text, out cantidadEjes))
            {
                this.camionModificado.CantidadEjes = cantidadEjes;
            }

        }
    }
}
