using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelsHub.Logica
{
        
    public class Funciones
    {
        AccesoDatos datos = new AccesoDatos();

        #region Metodos
        /// <summary>
        /// Valida si un valor entero corto (short) se encuentra dentro de un rango específico.
        /// </summary>
        /// <param name="valorIngresado">El valor entero corto a ser validado.</param>
        /// <param name="mensajeError">El mensaje de error a mostrar en caso de que el valor esté fuera del rango.</param>
        /// <param name="valorMinimo">El valor mínimo del rango permitido (inclusive).</param>
        /// <param name="valorMaximo">El valor máximo del rango permitido (inclusive).</param>
        /// <returns>
        /// Devuelve "true" si el valor ingresado está dentro del rango especificado; de lo contrario, devuelve "false".
        /// </returns>
        public static bool ValidarRango(short valorIngresado, string mensajeError, string titulo, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { Console.WriteLine(mensajeError); }
            return retorno;
        }
        /// <summary>
        /// Valida si un valor entero corto (int) se encuentra dentro de un rango específico.
        /// </summary>
        /// <param name="valorIngresado">El valor entero corto a ser validado.</param>
        /// <param name="mensajeError">El mensaje de error a mostrar en caso de que el valor esté fuera del rango.</param>
        /// <param name="valorMinimo">El valor mínimo del rango permitido (inclusive).</param>
        /// <param name="valorMaximo">El valor máximo del rango permitido (inclusive).</param>
        /// <returns>
        /// Devuelve "true" si el valor ingresado está dentro del rango especificado; de lo contrario, devuelve "false".
        /// </returns>
        public static bool ValidarRango(int valorIngresado, string mensajeError, string titulo, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
            return retorno;
        }
        /// <summary>
        /// Valida si un valor entero corto (double) se encuentra dentro de un rango específico.
        /// </summary>
        /// <param name="valorIngresado">El valor entero corto a ser validado.</param>
        /// <param name="mensajeError">El mensaje de error a mostrar en caso de que el valor esté fuera del rango.</param>
        /// <param name="valorMinimo">El valor mínimo del rango permitido (inclusive).</param>
        /// <param name="valorMaximo">El valor máximo del rango permitido (inclusive).</param>
        /// <returns>
        /// Devuelve "true" si el valor ingresado está dentro del rango especificado; de lo contrario, devuelve "false".
        /// </returns>
        public static bool ValidarRango(double valorIngresado, string mensajeError, string titulo, double valorMinimo, double valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
            return retorno;
        }
        /// <summary>
        /// Valida si la cadena de texto proporcionada es un número entero válido.
        /// </summary>
        /// <param name="valorIngresado">Cadena de texto que se intentará convertir a un número double.</param>
        /// <param name="valorSalida">Variable de salida que contendrá el valor convertido si la validación es exitosa.</param>
        /// <returns>
        /// Retorna true si la cadena de texto se puede convertir a un número entero con éxito,
        /// de lo contrario, retorna false y muestra un mensaje de advertencia.
        /// </returns>
        public static bool validarNumero(string valorIngresado, out double valorSalida)
        {
            bool retorno = false;
            if (double.TryParse(valorIngresado, out valorSalida))
            {
                retorno = true;
            }
            return retorno;
        }
       
        /// <summary>
        /// Valida si la cadena de texto proporcionada es un número entero válido.
        /// </summary>
        /// <param name="valorIngresado">Cadena de texto que se intentará convertir a un número entero.</param>
        /// <param name="valorSalida">Variable de salida que contendrá el valor convertido si la validación es exitosa.</param>
        /// <returns>
        /// Retorna true si la cadena de texto se puede convertir a un número entero con éxito,
        /// de lo contrario, retorna false y muestra un mensaje de advertencia.
        /// </returns>
        public static bool validarNumero(string valorIngresado, out int valorSalida)
        {
            bool retorno = false;
            if (int.TryParse(valorIngresado, out valorSalida))
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Obtiene la lista de motos almacenadas en la base de datos.
        /// </summary>
        /// <param name="listaMotos">Lista de motos obtenida de la base de datos.</param>
        /// <returns>True si se obtuvo la lista exitosamente, false en caso contrario.</returns>
        /// 
        public static bool ObtenerLista(out List<Moto> listaMotos)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Vehiculo> lista;
            bool retorno = false;
            listaMotos = new List<Moto>();

            lista =datos.ObtenerListaVehiculos();

            foreach (Vehiculo vehiculo in lista)
            {
                if (vehiculo is Moto)
                {
                    listaMotos.Add((Moto)vehiculo);
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Obtiene la lista de autos almacenados en la base de datos.
        /// </summary>
        /// <param name="listaAutos">Lista de autos obtenida de la base de datos.</param>
        /// <returns>True si se obtuvo la lista exitosamente, false en caso contrario.</returns>
        public static bool ObtenerLista(out List<Auto> listaAutos)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Vehiculo> lista;
            bool retorno = false;
            listaAutos = new List<Auto>();

            lista = datos.ObtenerListaVehiculos();

            foreach (Vehiculo vehiculo in lista)
            {
                if (vehiculo is Auto)
                {
                    listaAutos.Add((Auto)vehiculo);
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Obtiene la lista de camiones almacenados en la base de datos.
        /// </summary>
        /// <param name="listaCamion">Lista de camiones obtenida de la base de datos.</param>
        /// <returns>True si se obtuvo la lista exitosamente, false en caso contrario.</returns>
        public static bool ObtenerLista(out List<Camion> listaCamion)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Vehiculo> lista;
            bool retorno = false;
            listaCamion = new List<Camion>();

            lista = datos.ObtenerListaVehiculos();

            foreach (Vehiculo vehiculo in lista)
            {
                if (vehiculo is Camion)
                {
                    listaCamion.Add((Camion)vehiculo);
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool EsNumero(KeyPressEventArgs e)
        {
            bool retorno = false;
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                retorno = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                retorno = true;
            }
            else
            {
                e.Handled = true;
            }
            return retorno;
        }
        public static bool TextVacio(TextBox text)
        { 
            bool retorno = false;

            if (text.Text != string.Empty)
            {
                text.Focus();
                retorno = true;
            
            }
            return retorno;
        }
        public static bool ValidarEmail(string correo)
        {
           return correo != null && Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");//Expresion regular para validar correo
        }


        #endregion

    }
}
