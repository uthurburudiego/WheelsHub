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
    public partial class FormAgregarAuto : FormAgregar
    {

        Auto nuevoAuto;
        AccesoDatos datos;
        public FormAgregarAuto()
        {
            InitializeComponent();
            this.nuevoAuto = new Auto();
            this.datos = new AccesoDatos();

            Controls.Remove(this.txtCilindrada);
            Controls.Remove(this.cboABS);
            Controls.Remove(this.lblABS);
            Controls.Remove(this.lblCilindrada);
            Controls.Remove(this.txtTara);
            Controls.Remove(this.txtCantidadEjes);
            Controls.Remove(this.lblTara);
            Controls.Remove(this.lblEjes);
            lblTitulo.Text = "Agregar Auto";
            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasAutos));
      

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.AgregarAuto(RecuperarInformacion(this.nuevoAuto));
            this.Close();

        }
        private Auto RecuperarInformacion(Auto auto)
        {
            double costo = 0;
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            auto.Modelo = txtModelo.Text;
            auto.NumeroChasis = txtChasis.Text;
            auto.Marca = (eMarcasAutos)cboMarca.SelectedItem;
            auto.Color = (eColores)cboColor.SelectedItem;
            auto.TipoVehiculo = eTipoVehiculo.Auto;

            if (validarNumero(txtCosto.Text, out costo))
            {
                auto.Costo = costo;
            }
            if (validarNumero(txtCantidadPasajeros.Text, out cantidadPasajeros))
            {
                auto.CantidadPasajeros = cantidadPasajeros;
            }
            if (validarNumero(txtCantidadPuertas.Text, out cantidadPuertas))
            {
                auto.CantidadPuertas = cantidadPuertas;
            }
            return auto;
        }

    }
}
