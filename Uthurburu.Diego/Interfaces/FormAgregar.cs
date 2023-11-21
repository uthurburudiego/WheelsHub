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
    public partial class FormAgregar : Form
    {
        List<Vehiculo> listaVehiculos;


        public FormAgregar()
        {
            InitializeComponent();

            //cboColor.DataSource = Enum.GetValues(typeof(eColores)); 
        }

        protected static bool validarNumero(string valorIngresado, out double valorSalida)
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
        protected static bool validarNumero(string valorIngresado, out int valorSalida)
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
        
        
    }
}
