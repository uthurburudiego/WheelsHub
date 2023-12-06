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
        
    public class Funciones: IValidar, IFunciones
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
        /// Verifica si la tecla presionada en un control de entrada es un número o un carácter de control.
        /// </summary>
        /// <param name="e">Argumentos del evento KeyPress que contiene la tecla presionada.</param>
        /// <returns>
        ///   <c>true</c> si la tecla presionada es un número o un carácter de control; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EsNumero(KeyPressEventArgs e)
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
        /// <summary>
        /// Verifica si el contenido de un control TextBox está vacío.
        /// </summary>
        /// <param name="text">El control TextBox a verificar.</param>
        /// <returns>
        ///   <c>true</c> si el contenido del control TextBox no está vacío; de lo contrario, <c>false</c>.
        /// </returns>
        public bool TextVacio(TextBox text)
        { 
            bool retorno = false;

            if (text.Text != string.Empty)
            {
                text.Focus();
                retorno = true;
            
            }
            return retorno;
        }
        /// <summary>
        /// Valida si una cadena de texto representa una dirección de correo electrónico válida.
        /// </summary>
        /// <param name="correo">La cadena de texto que se va a validar como correo electrónico.</param>
        /// <returns>
        ///   <c>true</c> si la cadena de texto es una dirección de correo electrónico válida; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ValidarEmail(string correo)
        {
           return correo != null && Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");//Expresion regular para validar correo
        }
        /// <summary>
        /// Intenta convertir una cadena de texto en un tipo numérico genérico.
        /// </summary>
        /// <typeparam name="T">El tipo numérico al que se intentará convertir la cadena de texto.</typeparam>
        /// <param name="valorIngresado">La cadena de texto que se intentará convertir.</param>
        /// <param name="valorSalida">Cuando la conversión es exitosa, contiene el valor convertido.</param>
        /// <returns>
        ///   <c>true</c> si la conversión es exitosa; de lo contrario, <c>false</c>.
        /// </returns>
        public bool validarNumero<T>(string valorIngresado, out T valorSalida)
        {
            if(valorIngresado == "")
                valorIngresado = "0";

            bool retorno = false;
            try
            {
                
                valorSalida = (T)Convert.ChangeType(valorIngresado, typeof(T));
                return  true;
                
            }
            catch (Exception)
            {
                validarNumero("0", out valorSalida);
                return false;
            }
        }
        /// <summary>
        /// Obtiene una lista de vehículos del tipo genérico especificado.
        /// </summary>
        /// <typeparam name="T">El tipo de vehículo que se desea obtener.</typeparam>
        /// <param name="vehiculo">Una lista de vehículos que se utilizará como referencia.</param>
        /// <returns>
        ///   Una lista de vehículos del tipo genérico especificado.
        /// </returns>
        public List<T> ObtenerLista<T>( List<T> vehiculo)
        {
     
            List<T> listaVehiculos = new List<T>();
            List<Vehiculo> lista = this.datos.ObtenerListaVehiculos();

            foreach (Vehiculo v in lista)
            {
                if (v is T)
                {
                    listaVehiculos.Add((T)Convert.ChangeType(v, typeof(T)));
                }
            }

            return listaVehiculos;
        }
        /// <summary>
        /// Limpia el contenido de un control TextBox estableciendo su texto a una cadena vacía.
        /// </summary>
        /// <param name="text">Control TextBox cuyo texto se va a limpiar.</param>
        public static void LimpiarTexto(TextBox text)
        {
            text.Text = string.Empty;
        }
            #endregion

        }
}
