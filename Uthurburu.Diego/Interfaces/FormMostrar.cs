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
    public partial class FormMostrar : Form
    {
        public FormMostrar(Vehiculo vehiculo)
        {
            InitializeComponent();
            Mostrar(vehiculo);


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Muestra la información detallada de un vehículo en los controles del formulario.
        /// </summary>
        /// <param name="vehiculo">Objeto de tipo Vehiculo que contiene la información a mostrar.</param>
        private void Mostrar(Vehiculo vehiculo)
        {
          
            CargarImagen(vehiculo);
            if (vehiculo is Moto)
            {
                Moto moto = (Moto)vehiculo;
                lblMarcaModelo.Text = $"{moto.Marca} -- {moto.Modelo}";
                lblInformacion.Text = moto.ToString();
                lblDrescripcion.Text = moto.ObtenerDescripcion();
                lblMantenimieto.Text = $"Costo de mantenimiento:\nUSD${moto.CalcularCostoMantenimiento():N2} por año.";
            }
            else if (vehiculo is Auto)
            {
                Auto auto = (Auto)vehiculo;
                lblMarcaModelo.Text = $"{auto.Marca} -- {auto.Modelo}";
                lblInformacion.Text = auto.ToString();
                lblDrescripcion.Text = auto.ObtenerDescripcion();
                lblMantenimieto.Text = $"Costo de mantenimiento:\nUSD${auto.CalcularCostoMantenimiento():N2} por año.";
            }
            else if (vehiculo is Camion)
            {
                Camion camion = (Camion)vehiculo;
                lblMarcaModelo.Text = $"{camion.Marca} -- {camion.Modelo}";
                lblInformacion.Text = camion.ToString();
                lblDrescripcion.Text = camion.ObtenerDescripcion();
                lblMantenimieto.Text = $"Costo de mantenimiento:\nUSD${camion.CalcularCostoMantenimiento():N2} por año.";

            }

        }
        /// <summary>
        /// Carga la imagen del vehículo en el control PictureBox.
        /// </summary>
        /// <param name="vehiculo">Objeto de tipo Vehiculo que contiene la información de la imagen.</param>
        private void CargarImagen(Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo.Foto != null && vehiculo.Foto.Length > 0)
                {
                    // Convierte el array de bytes a una imagen
                    using (MemoryStream ms = new MemoryStream(vehiculo.Foto))
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

    }
}
