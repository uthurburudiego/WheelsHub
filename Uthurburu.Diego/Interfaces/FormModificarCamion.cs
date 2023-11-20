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
    public partial class FormModificarCamion : FormAgregarCamion
    {
        Camion nuevoCamion;
        AccesoDatos datos;
        public FormModificarCamion(Camion camion)
        {
            InitializeComponent();
            datos = new AccesoDatos();

           MostrarInformacion(camion);


            txtChasis.Enabled = false;
            lblTitulo.Text = "Modificar Auto";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.nuevoCamion = RecuperarInformacion();
            if (datos.ModificarCamion(this.nuevoCamion))
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


        }
    }
}
