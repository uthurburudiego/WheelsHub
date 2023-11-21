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
    public partial class FormModificarMoto : FormAgregar
    {
        Moto motoModificada;
        AccesoDatos datos;
        public FormModificarMoto(Moto moto)
        {
            InitializeComponent();
            motoModificada = moto;
            datos = new AccesoDatos();
            MostrarInformacion(moto);

            txtChasis.Enabled = false;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
            if (datos.ModificarMoto(this.motoModificada))
            {
                MessageBox.Show("Se modifico con EXITO!!!", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se realizo la modificacion", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        protected void MostrarInformacion(Moto moto)
        {
            txtChasis.Text = moto.NumeroChasis;
            txtModelo.Text = moto.Modelo;
            cboMarca.SelectedItem = moto.Marca;
            cboColor.SelectedItem = moto.Color;
            cboABS.SelectedItem = moto.FrenosABS;
            txtCosto.Text = moto.Costo.ToString();
            txtCilindrada.Text = moto.Cilindrada.ToString();
            CargarImagen(moto);
        }
        private void CargarImagen(Moto moto)
        {
            try
            {
                if (moto.Foto != null && moto.Foto.Length > 0)
                {
                    // Convierte el array de bytes a una imagen
                    using (MemoryStream ms = new MemoryStream(moto.Foto))
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
            int cilindrada = 0;
            this.motoModificada.TipoVehiculo = eTipoVehiculo.Moto;
            this.motoModificada.NumeroChasis = txtChasis.Text;
            this.motoModificada.Modelo = txtModelo.Text;
            this.motoModificada.Marca = (eMarcasMotos)cboMarca.SelectedItem;
            this.motoModificada.Color = (eColores)cboColor.SelectedItem;
            this.motoModificada.FrenosABS = (eTipoDeFrenos)cboABS.SelectedItem;
            if (validarNumero(txtCosto.Text, out costo))
            {
                this.motoModificada.Costo = costo;
            }
            if (validarNumero(txtCilindrada.Text, out cilindrada))
            {
                this.motoModificada.Cilindrada = cilindrada;
            }

        }
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {
            this.motoModificada = GuardarImagen(this.motoModificada);
        }
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

