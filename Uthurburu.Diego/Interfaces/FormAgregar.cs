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
    public delegate void DelAdevetencia(string titulo, string mensaje);
    public partial class FormAgregar : Form
    {
        #region Atributos
        protected AccesoDatos datos;
        Funciones funciones;
        DelAdevetencia advertencia;
        #endregion

        #region Constructor
        public FormAgregar()
        {
            InitializeComponent();
            this.datos = new AccesoDatos();
            this.funciones = new Funciones();
            this.advertencia = new DelAdevetencia(MostrarAdevetencia);
        }
        #endregion


        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #endregion

        #region Metodos

        /// <summary>
        /// Valida y maneja el evento KeyPress para permitir solo la entrada de números en un TextBox.
        /// </summary>
        /// <param name="e">Argumentos del evento KeyPress.</param>
        /// <param name="box">TextBox en el que se está ingresando el número.</param>
        /// <remarks>
        /// Esta función utiliza la clase Funciones para verificar si el carácter ingresado es un número.
        /// Si el carácter no es un número, muestra un mensaje de error utilizando un ErrorProvider.
        /// </remarks>
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
        /// <summary>
        /// Recupera la información del formulario y la asigna a la instancia de la clase Auto.
        /// </summary>
        protected virtual bool RecuperarInformacion(Vehiculo nuevoVehiculo)
        {
            bool retorno = false;
            double costo = 0;
            if (funciones.TextVacio(txtChasis) || !this.datos.VehiculoExiste(txtChasis.Text) )
            {
                if (picImagen.Image != null)
                {

                    nuevoVehiculo.Modelo = txtModelo.Text;
                    nuevoVehiculo.NumeroChasis = txtChasis.Text;
                    nuevoVehiculo.Color = (eColores)cboColor.SelectedItem;
                    retorno = true;



                    if (funciones.validarNumero(txtCosto.Text, out costo) &&
                        Funciones.ValidarRango(costo, "El Costo no puede ser menor que 0", "Precio", 0, 9999999))
                    {
                        nuevoVehiculo.Costo = costo;
                    }
                }
                else
                {
                    this.advertencia("Advertencia", "Debe agregar una imagen ");
                }
            }
            else
            {
                this.advertencia("Advertencia","El campo N° de chasis es obligatorio ");
            }

            
            return retorno;

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
               this.advertencia("Cargar Imagen", $"{ex.Message}");
            }
        }
        protected void GuardarImagen(Vehiculo vehiculo)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            dlgImagen.Filter = "Archivos de imagen|*.png;*.jpg;";
            if (dlgImagen.ShowDialog() == DialogResult.OK)
            {
                string pathImagen = dlgImagen.FileName;
                picImagen.ImageLocation = pathImagen;
                vehiculo.Foto = File.ReadAllBytes(pathImagen);
            }
            
        }
        protected void MostrarAdevetencia(string titulo, string mensaje)
        {
            FormMessageBox messageBox = new FormMessageBox(titulo, mensaje);
            messageBox.ShowDialog();
        }
        #endregion
    }
}
