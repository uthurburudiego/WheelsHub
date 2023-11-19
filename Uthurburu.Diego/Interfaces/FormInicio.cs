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
    public partial class FormInicio : Form
    {
        List<Moto> listaMotos;
        List<Auto> listaAutos;
        List<Camion> listaCamion;
        List<Vehiculo> vehiculos;
        string numeroChasis;

        AccesoDatos datos;
        public FormInicio()
        {
            InitializeComponent();
            datos = new AccesoDatos();

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            FormLogIn logIn = new FormLogIn();
            logIn.ShowDialog();

            lblSaludo.Text = $"Bienvenido, {logIn.Usuario.Perfil}: {logIn.Usuario.Nombre}";

            this.vehiculos = datos.ObtenerListaVehiculos();
            dtgVehiculos.DataSource = vehiculos;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgVehiculos.AutoSize = true;

        }

        //Botones ToolStrip

        //VER
        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaAutos = this.datos.ObtenerListaAuto();
            dtgVehiculos.DataSource = listaAutos;
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaCamion = this.datos.ObtenerListaCamion();
            dtgVehiculos.DataSource = listaCamion;
        }

        private void motosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaMotos = this.datos.ObtenerListaMoto();
            dtgVehiculos.DataSource = listaMotos;
        }

        //AGREGAR
        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarAuto nuevoAuto = new FormAgregarAuto();
            nuevoAuto.ShowDialog();
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMoto nuevaMoto = new FormAgregarMoto();
            nuevaMoto.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCamion nuevoCamion = new FormAgregarCamion();
            nuevoCamion.ShowDialog();
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.numeroChasis))
            {
                datos.BorrarVehiculo(this.numeroChasis);
            }
        }

        private void dtgVehiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = dtgVehiculos.SelectedCells[0].RowIndex;
            this.numeroChasis = dtgVehiculos.Rows[selectedRowIndex].Cells["NumeroChasis"].Value.ToString();
        }
    }
}
