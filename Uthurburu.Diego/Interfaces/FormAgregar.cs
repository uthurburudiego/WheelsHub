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
    public partial class FormAgregar : Form
    {
        protected Moto nuevaMoto;
        protected Auto nuevoAuto;
        protected Camion nuevoCamion;
        protected AccesoDatos datos;

        public FormAgregar()
        {
            InitializeComponent();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void MostrarInformacion(Vehiculo vehiculo)
        {
            txtChasis.Text = vehiculo.NumeroChasis;
            txtModelo.Text = vehiculo.Modelo;
            cboColor.SelectedItem = vehiculo.Color;
            txtCosto.Text = vehiculo.Costo.ToString();
            CargarImagen(vehiculo);
        }
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
