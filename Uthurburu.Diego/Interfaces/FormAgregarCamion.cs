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
    public partial class FormAgregarCamion : FormAgregar
    {
        Camion nuevoCamion;
        AccesoDatos datos;
        public FormAgregarCamion()
        {
            InitializeComponent();
            nuevoCamion = new Camion();
            datos = new AccesoDatos();

            Controls.Remove(this.txtCantidadPasajeros);
            Controls.Remove(this.txtCantidadPuertas);
            Controls.Remove(this.lblPasajeros);
            Controls.Remove(this.lblPuertas);
            Controls.Remove(this.txtCilindrada);
            Controls.Remove(this.cboABS);
            Controls.Remove(this.lblABS);
            Controls.Remove(this.lblCilindrada);

            lblTitulo.Text = "Agregar Camion";

            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasCamiones));


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.AgregarCamion(RecuperarInformacion());
            this.Close();
        }

        protected Camion RecuperarInformacion()
        {
            double costo = 0;
            int tara = 0;
            int cantidadEjes = 0;
            nuevoCamion.TipoVehiculo = eTipoVehiculo.Camion;
            nuevoCamion.Modelo = txtModelo.Text;
            nuevoCamion.NumeroChasis = txtChasis.Text;
            nuevoCamion.Marca = (eMarcasCamiones)cboMarca.SelectedItem;
            nuevoCamion.Color = (eColores)cboColor.SelectedItem;

            if (validarNumero(txtCosto.Text, out costo))
            {
                nuevoCamion.Costo = costo;
            }
            if (validarNumero(txtTara.Text, out tara))
            {
                nuevoCamion.Tara = tara;
            }
            if (validarNumero(txtCantidadEjes.Text, out cantidadEjes))
            {
                nuevoCamion.CantidadEjes = cantidadEjes;
            }
            return nuevoCamion;
        }
    }
}
