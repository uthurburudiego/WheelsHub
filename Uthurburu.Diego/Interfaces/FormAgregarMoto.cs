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
    public partial class FormAgregarMoto : FormAgregar
    {
        Moto nuevaMoto;
        AccesoDatos datos;
        public FormAgregarMoto()
        {
            InitializeComponent();

            nuevaMoto = new Moto();
            datos = new AccesoDatos();


            Controls.Remove(this.txtCantidadPasajeros);
            Controls.Remove(this.txtCantidadPuertas);
            Controls.Remove(this.txtCantidadEjes);
            Controls.Remove(this.txtTara);
            Controls.Remove(this.lblTara);
            Controls.Remove(this.lblEjes);
            Controls.Remove(this.lblPasajeros);
            Controls.Remove(this.lblPuertas);

            lblTitulo.Text = "Agregar Moto";

            cboABS.DataSource = Enum.GetValues(typeof(eTipoDeFrenos));
            cboMarca.DataSource = Enum.GetValues(typeof(eMarcasMotos));
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.AgregarMoto(RecuperarInformacion(this.nuevaMoto));
            this.Close();
        }

        private Moto RecuperarInformacion(Moto moto)
        {
            double costo = 0;
            int cilindrada = 0;
            moto.TipoVehiculo = eTipoVehiculo.Moto;
            moto.NumeroChasis = txtChasis.Text;
            moto.Modelo = txtModelo.Text;
            moto.Marca = (eMarcasMotos)cboMarca.SelectedItem;
            moto.Color = (eColores)cboColor.SelectedItem;
            moto.FrenosABS = (eTipoDeFrenos)cboABS.SelectedItem;
            if (validarNumero(txtCosto.Text, out costo))
            {
                moto.Costo = costo;
            }
            if (validarNumero(txtCilindrada.Text, out cilindrada))
            {
                moto.Cilindrada = cilindrada;
            }
            return moto;
        }
    }
}
