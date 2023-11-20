using Entidades;
using Newtonsoft.Json.Bson;
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
        List<Vehiculo> listaVehiculos;
        string numeroChasis;

        AccesoDatos datos;
        public FormInicio()
        {
            InitializeComponent();
            datos = new AccesoDatos();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            IniciarSesion();

            todosToolStripMenuItem_Click(sender, e);
            dtgVehiculos.AutoSize = true;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        //Botones ToolStrip

        //VER
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaVehiculos = datos.ObtenerListaVehiculos();
            dtgVehiculos.DataSource = listaVehiculos;

        }
        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.datos.ObtenerLista(out listaAutos);
            dtgVehiculos.DataSource = listaAutos;
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.datos.ObtenerLista(out this.listaCamion);
            dtgVehiculos.DataSource = listaCamion;
        }

        private void motosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.datos.ObtenerLista(out this.listaMotos);
            dtgVehiculos.DataSource = listaMotos;
        }

        //AGREGAR
        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarAuto nuevoAuto = new FormAgregarAuto();
            nuevoAuto.ShowDialog();
            todosToolStripMenuItem_Click(sender, e);
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMoto nuevaMoto = new FormAgregarMoto();
            nuevaMoto.ShowDialog();
            todosToolStripMenuItem_Click(sender, e);
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCamion nuevoCamion = new FormAgregarCamion();
            nuevoCamion.ShowDialog();
            todosToolStripMenuItem_Click(sender, e);
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.numeroChasis))
            {
                datos.BorrarVehiculo(this.numeroChasis);
                todosToolStripMenuItem_Click(sender, e);
            }
        }

        private void dtgVehiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = dtgVehiculos.SelectedCells[0].RowIndex;
            this.numeroChasis = dtgVehiculos.Rows[selectedRowIndex].Cells["NumeroChasis"].Value.ToString();
        }

        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IniciarSesion();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            Vehiculo vehiculoEncontrado = listaVehiculos.Find(moto => moto.NumeroChasis == numeroChasis);
            if (vehiculoEncontrado is Moto)
            {
                FormModificarMoto modificarMoto = new FormModificarMoto((Moto)vehiculoEncontrado);
                modificarMoto.ShowDialog();

            }
            else if (vehiculoEncontrado is Auto)
            {
                FormModificarAuto modificarAuto = new FormModificarAuto((Auto)vehiculoEncontrado);
                modificarAuto.ShowDialog();
            }
            else if (vehiculoEncontrado is Camion)
            { 
               FormModificarCamion modificarCamion = new FormModificarCamion((Camion)vehiculoEncontrado);   
                modificarCamion.ShowDialog();
            
            }
                todosToolStripMenuItem_Click(sender, e);

        }
        /// <summary>
        /// Inicia el proceso de inicio de sesión y muestra información de bienvenida.
        /// </summary>
        private void IniciarSesion()
        {
            this.Hide();
            DateTime currentDate = DateTime.Now;

            FormLogIn logIn = new FormLogIn();
            logIn.ShowDialog();
            this.Show();

            lblSaludo.Text = $"Bienvenido, {logIn.Usuario.Perfil}: {logIn.Usuario.Nombre}";
            lblFecha.Text = $"{currentDate.ToString("dd/MM/yyyy")}";
        }

    }
}
