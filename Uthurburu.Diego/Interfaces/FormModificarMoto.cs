﻿using System;
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
    public partial class FormModificarMoto : FormAgregarMoto
    {
        #region Contructor
        public FormModificarMoto(Moto moto)
        {
            InitializeComponent();
            this.nuevaMoto = moto;
          
        }
        #endregion

        #region Botones
        protected override void btnGuardar_Click(object sender, EventArgs e)
        {
            this.esModificacion = true;
            RecuperarInformacion(this.nuevaMoto, this.esModificacion);
            datos.AltaModificacionVehiculo(this.nuevaMoto, "UPDATE");
            this.Close();
        }
        private void FormModificarMoto_Load(object sender, EventArgs e)
        {
            txtChasis.Enabled = false;
            MostrarInformacion(this.nuevaMoto);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la información del vehículo en los controles del formulario.
        /// </summary>
        /// <param name="vehiculo">Objeto de tipo Vehiculo que contiene la información a mostrar.</param>
        protected override void MostrarInformacion(Vehiculo vehiculo)
        {
            base.MostrarInformacion(vehiculo);
            txtCilindrada.Text = this.nuevaMoto.Cilindrada.ToString();
            cboABS.SelectedItem = this.nuevaMoto.FrenosABS;
            cboMarca.SelectedItem = this.nuevaMoto.Marca;
        }
        #endregion
    }
}
