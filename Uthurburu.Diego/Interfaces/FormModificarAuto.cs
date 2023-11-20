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
    public partial class FormModificarAuto : FormAgregarAuto
    {
        Auto nuevoAuto;
        AccesoDatos datos;
        public FormModificarAuto(Auto auto)
        {
            InitializeComponent();
            datos = new AccesoDatos();
            MostrarInformacion(auto);
      


            txtChasis.Enabled = false;
            lblTitulo.Text = "Modificar Auto";
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.nuevoAuto = RecuperarInformacion();
            if (datos.ModificarAuto(this.nuevoAuto))
            {
                MessageBox.Show("Se modifico con EXITO!!!", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se realizo la modificacion", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
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
        }

    }
}
