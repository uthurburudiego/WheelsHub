using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO;
using WheelsHub.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Collections;


namespace WheelsHub
{
    public partial class FormCargarStock : Form
    {
        public FormCargarStock()
        {
            

            InitializeComponent();
            cbMarcas.DataSource = Enum.GetValues(typeof(eMarcasMotos));
            cbMarcas.DataSource = Enum.GetValues(typeof(eMarcasCamiones));
            cbMarcas.DataSource = Enum.GetValues(typeof(eMarcasAutos));

            cbColor.DataSource = Enum.GetValues(typeof(eColores));
            cbTipoVehiculo.DataSource = Enum.GetValues(typeof(eTipoVehiculo));
            cbABS.DataSource = Enum.GetValues(typeof(eTipoDeFrenos));
        }

        // TODOS LOS COMBOBOX
        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoVehiculo.Text == "Autos")
            {
                eMarcasAutos marcas = (eMarcasAutos)cbMarcas.SelectedItem;
            }
            if (cbTipoVehiculo.Text == "Motos")
            {
                eMarcasMotos marcas = (eMarcasMotos)cbMarcas.SelectedItem;
            }
            if (cbTipoVehiculo.Text == "Camion")
            {
                eMarcasCamiones marcas = (eMarcasCamiones)cbMarcas.SelectedItem;
            }
        }
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            eColores color = (eColores)cbColor.SelectedItem;
        }
        private void cbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            eTipoVehiculo tipoVehiculo = (eTipoVehiculo)cbTipoVehiculo.SelectedItem;
        }
        
        // FUNCIONES DE LOS BOTONES ACEPTAR Y CANCELAR 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario hizo clic en "Sí" (Yes)
            if (result == DialogResult.Yes)
            {
                // Si el usuario confirma, cerrar el form
                this.Close();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Vehiculo> listaDeVehiculos;



            if (File.Exists(ManejadorDeArchivos.CalcularRuta()))
            {
                string contenidoActual = File.ReadAllText(ManejadorDeArchivos.CalcularRuta());
                listaDeVehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(contenidoActual);
            }
            else
            {
                // Si el archivo no existe, crea una nueva lista
                listaDeVehiculos = new List<Vehiculo>();
            }

            // Paso 2: Agrega el nuevo vehículo a la lista
            switch (cbTipoVehiculo.Text)
            {
                case "Auto":
                    listaDeVehiculos.Add(RecuperarInformacion(new Auto()));

                    break;
                case "Moto":
                    listaDeVehiculos.Add(RecuperarInformacion(new Moto()));
                    break;
                case "Camion":
                    listaDeVehiculos.Add(RecuperarInformacion(new Camion()));
                    break;
                default:
                    break;
            }

            // Paso 3: Escribe la lista completa en el archivo JSON
            string nuevaListaJson = JsonConvert.SerializeObject(listaDeVehiculos);
            File.WriteAllText(ManejadorDeArchivos.CalcularRuta(), nuevaListaJson);

            LimpiarTextBox(this);
            LimpiarComboBox(this);
            listBoxVehiculos.Items.Add(nuevaListaJson.ToString());
            listBoxVehiculos.Refresh();
            MessageBox.Show("Se ha agregado con éxito!");
        }
        private void cbTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {

            txtCanPuertas.Enabled = false;
            txtCantPasajeros.Enabled = false;
            txtCilindrada.Enabled = false;
            cbABS.Enabled = false;
            txtCantEjes.Enabled = false;
            txtTara.Enabled = false;


            switch (cbTipoVehiculo.Text)
            {
                case "Auto":
                    txtCanPuertas.Enabled = true;
                    txtCantPasajeros.Enabled = true;
                    break;
                case "Moto":

                    txtCilindrada.Enabled = true;
                    cbABS.Enabled = true;
                    cbMarcas.DataSource = Enum.GetValues(typeof(eMarcasMotos));

                    break;
                case "Camion":
                    txtCantEjes.Enabled = true;
                    txtTara.Enabled = true;

                    break;
                default:
                    break;
            }

        }

        private Auto RecuperarInformacion(Auto auto)
        {
            double costo = 0;
            int cantidadPasajeros = 0;
            int cantidadPuertas = 0;

            auto.Modelo = txtModelo.Text;
            auto.NumeroChasis = txtNumChasis.Text;
            auto.Marca = (eMarcasAutos)cbMarcas.SelectedItem;
            auto.Color = (eColores)cbColor.SelectedItem;
            auto.TipoVehiculo = (eTipoVehiculo)cbTipoVehiculo.SelectedItem;
         
            if (validarNumero(txtCosto.Text, out costo))
            {
                auto.Costo = costo;
            }
            if (validarNumero(txtCantPasajeros.Text, out cantidadPasajeros))
            {
                auto.CantidadPasajeros= cantidadPasajeros;
            }
            if (validarNumero(txtCanPuertas.Text, out cantidadPuertas))
            {
                auto.CantidadPuertas= cantidadPuertas;
            }
            return auto;

        }
        private Moto RecuperarInformacion(Moto moto)
        {
            double costo = 0;
            int cilindrada = 0;
            moto.TipoVehiculo = (eTipoVehiculo)cbTipoVehiculo.SelectedItem;
            moto.NumeroChasis = txtNumChasis.Text;
            moto.Modelo = txtModelo.Text;
            moto.Marca = (eMarcasMotos)cbMarcas.SelectedItem;
            moto.Color = (eColores)cbColor.SelectedItem;
            moto.FrenosABS = (eTipoDeFrenos)cbABS.SelectedItem;
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
        private Camion RecuperarInformacion(Camion camion)
        {
            double costo = 0;
            int tara = 0;
            int cantidadEjes = 0;
            camion.TipoVehiculo = (eTipoVehiculo)cbTipoVehiculo.SelectedItem;
            camion.Modelo = txtModelo.Text;
            camion.NumeroChasis = txtNumChasis.Text;
            camion.Marca = (eMarcasCamiones)cbMarcas.SelectedItem;
            camion.Color = (eColores)cbColor.SelectedItem;
             
            if (validarNumero(txtCosto.Text, out costo))
            {
                camion.Costo = costo;
            }
            if (validarNumero(txtTara.Text, out tara))
            {
                camion.Tara = tara;
            }
            if (validarNumero(txtCantEjes.Text, out cantidadEjes))
            {
                camion.CantidadEjes= cantidadEjes;
            }
            return camion;
        }
        static bool validarNumero(string valorIngresado, out double valorSalida)
        {
            bool retorno = false;
            if (double.TryParse(valorIngresado, out valorSalida))
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Para este campo debe ingresar solo numeros.");
            }
            return retorno;
        }
        static bool validarNumero(string valorIngresado, out int valorSalida)
        {
            bool retorno = false;
            if (int.TryParse(valorIngresado, out valorSalida))
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Para este campo debe ingresar solo numeros.");
            }
            return retorno;
        }
        static bool validarNumero(string valorIngresado, out short valorSalida)
        {
            bool retorno = false;
            if (short.TryParse(valorIngresado, out valorSalida))
            {
                retorno = true;
            }
            else
            {
                MessageBox.Show("Para este campo debe ingresar solo numeros.");
            }
            return retorno;
        }
        private void LimpiarTextBox(Control control) 
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    LimpiarTextBox(c);
                }
            }
        }
        private void LimpiarComboBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    comboBox.SelectedIndex = 0;
                }
                else if (c.HasChildren)
                {
                    LimpiarComboBox(c);
                }
            }
        }
        
        private void CargarAutosEnListBox()
        {
            List<Auto> autos = ManejadorDeArchivos.CargarAutos();

            foreach (Auto auto in autos)
            {
                listBoxVehiculos.Items.Add(auto.ToString());
            }
        }
        private void CargarMotosEnListBox()
        {
            List<Moto> motos = ManejadorDeArchivos.CargarMotos();

            foreach (Moto moto in motos)
            {
                listBoxVehiculos.Items.Add(moto.ToString());
            }
        }
        private void CargarCamionesEnListBox()
        {
            List<Camion> camiones = ManejadorDeArchivos.CargarCamiones();

            foreach (Camion camion in camiones)
            {
                listBoxVehiculos.Items.Add(camion.ToString());
            }
        }

        private void FormCargarStock_Load(object sender, EventArgs e)
        {
            CargarMotosEnListBox();
            CargarAutosEnListBox();
            CargarCamionesEnListBox();
        }

       
    }
}

