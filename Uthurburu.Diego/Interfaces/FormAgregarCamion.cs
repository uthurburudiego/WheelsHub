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
            datos.AgregarCamion(RecuperarInformacion(this.nuevoCamion));
            this.Close();
        }

        private Camion RecuperarInformacion(Camion camion)
        {
            double costo = 0;
            int tara = 0;
            int cantidadEjes = 0;
            camion.TipoVehiculo = eTipoVehiculo.Camion;
            camion.Modelo = txtModelo.Text;
            camion.NumeroChasis = txtChasis.Text;
            camion.Marca = (eMarcasCamiones)cboMarca.SelectedItem;
            camion.Color = (eColores)cboColor.SelectedItem;

            if (validarNumero(txtCosto.Text, out costo))
            {
                camion.Costo = costo;
            }
            if (validarNumero(txtTara.Text, out tara))
            {
                camion.Tara = tara;
            }
            if (validarNumero(txtCantidadEjes.Text, out cantidadEjes))
            {
                camion.CantidadEjes = cantidadEjes;
            }
            return camion;
        }
    }
}
