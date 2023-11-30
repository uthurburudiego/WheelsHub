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
        /// <summary>
        /// Muestra la información de un vehículo en los controles del formulario.
        /// </summary>
        /// <param name="vehiculo">El vehículo del cual se mostrará la información.</param>
        protected virtual void MostrarInformacion(Vehiculo vehiculo)
        {
            txtChasis.Text = vehiculo.NumeroChasis;
            txtModelo.Text = vehiculo.Modelo;
            cboColor.SelectedItem = vehiculo.Color;
            txtCosto.Text = vehiculo.Costo.ToString();
            CargarImagen(vehiculo);
        }
        /// <summary>
        /// Carga la imagen del vehículo en un PictureBox.
        /// </summary>
        /// <param name="vehiculo">El vehículo del cual se cargará la imagen.</param>
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

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            cboColor.DataSource = Enum.GetValues(typeof(eColores));
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtCosto);
        }
        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtCilindrada);
        }
        private void txtTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtTara);
        }
        private void txtCantidadEjes_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtCantidadEjes);
        }
        private void txtCantidadPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtCantidadPuertas);
        }
        private void txtCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumeros(e, txtCantidadPasajeros);
        }

        protected void InputNumeros(KeyPressEventArgs e, TextBox box)
        {
            if (!Funciones.EsNumero(e))
            {
                this.epErrores.SetError(box, "Solo se admiten numeros");
            }
            else
            {
                this.epErrores.Clear();
            }
        }

    }
}
