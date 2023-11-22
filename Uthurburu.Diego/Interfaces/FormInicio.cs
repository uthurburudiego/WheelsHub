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
        FormLogIn logIn = new FormLogIn();
        List<Moto> listaMotos;
        List<Auto> listaAutos;
        List<Camion> listaCamion;
        List<Vehiculo> listaVehiculos;
        int indiceImagenActual = 0;
        readonly string[] nombresImagenes = { "fondo1", "fondo2", "fondo3" }; 
        const int intervaloCambioImagen = 10000; 


        string numeroChasis;

        AccesoDatos datos;
        public FormInicio()
        {
            InitializeComponent();
            datos = new AccesoDatos();
            CambiarImagenDeFondo();

            IniciarCambioAutomatico();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            IniciarSesion();
            todosToolStripMenuItem_Click(sender, e);
            dtgVehiculos.AutoSize = true;
            dtgVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            this.BackgroundImage = Properties.Resources.fondo1;

            switch (this.logIn.Usuario.Perfil)
            {
                case "administrador":

                    break;
                case "supervisor":
                    btnBorrar.Enabled = false;
                    registrosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Enabled = false;
                    break;
                case "vendedor":
                    btnBorrar.Enabled = false;
                    btnModificar.Enabled = false;
                    registrosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Enabled = false;
                    agregarToolStripMenuItem.Enabled = false;
                    break;
            }

        }
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaVehiculos = datos.ObtenerListaVehiculos();
            dtgVehiculos.DataSource = listaVehiculos;

        }
        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Funciones.ObtenerLista(out listaAutos);
            dtgVehiculos.DataSource = listaAutos;
        }
        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Funciones.ObtenerLista(out this.listaCamion);
            dtgVehiculos.DataSource = listaCamion;
        }
        private void motosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Funciones.ObtenerLista(out this.listaMotos);
            dtgVehiculos.DataSource = listaMotos;
        }
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
        private void btnModificar_Click(object sender, EventArgs e)
        {

            Vehiculo vehiculoEncontrado = listaVehiculos.Find(v => v.NumeroChasis == this.numeroChasis);

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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgVehiculos.DataSource = Buscador(txtBuscador.Text);
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerUsuarios verUsuarios = new FormVerUsuarios();
            verUsuarios.ShowDialog();
        }
        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroConexion registroConexion = new FormRegistroConexion();
            registroConexion.ShowDialog();
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                btnBuscar_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
        }
        private void dtgVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMostrar mostrar = new FormMostrar(listaVehiculos.Find(v => v.NumeroChasis == this.numeroChasis));
            mostrar.ShowDialog();
        }
        /// <summary>
        /// Inicia el proceso de inicio de sesión y muestra información de bienvenida.
        /// </summary>
        private void IniciarSesion()
        {
            DateTime currentDate = DateTime.Now;

            this.logIn.ShowDialog();
            this.Show();

            lblSaludo.Text = $"Bienvenido, {this.logIn.Usuario.Perfil}: {this.logIn.Usuario.Nombre}";
            lblFecha.Text = $"{currentDate.ToString("dd/MM/yyyy")}";

        }
        /// <summary>
        /// Realiza una búsqueda en la lista de vehículos basándose en el texto de búsqueda.
        /// </summary>
        /// <param name="textoBusqueda">Texto utilizado para buscar coincidencias en los atributos de los vehículos.</param>
        /// <returns>Una lista de vehículos que coinciden con el texto de búsqueda.</returns>
        private List<Vehiculo> Buscador(string textoBusqueda)
        {
            List<Vehiculo> coincidencias = this.listaVehiculos.Where(v => v.Modelo.Contains(textoBusqueda) || v.NumeroChasis.Contains(textoBusqueda) || v.Costo.ToString().Contains(textoBusqueda) || v.Color.ToString().Contains(textoBusqueda) || v.TipoVehiculo.ToString().Contains(textoBusqueda)).ToList();

            return coincidencias;
        }
        /// <summary>
        /// Cambia la imagen de fondo del formulario utilizando imágenes almacenadas en los recursos.
        /// </summary>
        private void CambiarImagenDeFondo()
        {
            // Asegúrate de manejar excepciones aquí si es necesario.
            try
            {
                // Accede a la imagen desde los recursos y cambia la imagen de fondo del formulario.
                BackgroundImage = Properties.Resources.ResourceManager.GetObject(nombresImagenes[indiceImagenActual]) as Image;
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus necesidades.
                Console.WriteLine($"Error al cargar la imagen desde recursos: {ex.Message}");
            }
        }
        /// <summary>
        /// Inicia un bucle asíncrono para cambiar automáticamente la imagen de fondo del formulario a intervalos regulares.
        /// </summary>
        private async void IniciarCambioAutomatico()
        {
            while (true)
            {
                await Task.Delay(intervaloCambioImagen);
                // Cambia al siguiente índice de imagen.
                indiceImagenActual = (indiceImagenActual + 1) % nombresImagenes.Length;
                // Cambia la imagen de fondo del formulario.
                CambiarImagenDeFondo();
            }
        }


    }
}
