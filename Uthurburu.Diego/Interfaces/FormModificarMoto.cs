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
    public partial class FormModificarMoto : FormAgregarMoto
    {
        Moto nuevaMoto;
        AccesoDatos datos;
        public FormModificarMoto(Moto moto)
        {
            InitializeComponent();
            nuevaMoto = moto;
            datos = new AccesoDatos();
            MostrarInformacion(moto);

            txtChasis.Enabled = false;
            lblTitulo.Text = "Modificar Moto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.nuevaMoto = RecuperarInformacion();
            if (datos.ModificarMoto(this.nuevaMoto))
            {
                MessageBox.Show("Se modifico con EXITO!!!", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se realizo la modificacion", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void MostrarInformacion(Moto moto)
        {
            txtChasis.Text = moto.NumeroChasis;
            txtModelo.Text = moto.Modelo;
            cboMarca.SelectedItem = moto.Marca;
            cboColor.SelectedItem = moto.Color;
            cboABS.SelectedItem = moto.FrenosABS;
            txtCosto.Text = moto.Costo.ToString();
            txtCilindrada.Text = moto.Cilindrada.ToString();


        }
    }
}
