using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelsHub.Logica
{
    public class Funciones
    {
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
        public static bool ValidarRango(short valorIngresado, string mensajeError, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError,"ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
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
        public static bool ValidarRango(int valorIngresado, string mensajeError, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
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
        public static bool ValidarRango(double valorIngresado, string mensajeError, double valorMinimo, double valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
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
            else
            {
                MessageBox.Show("Para este campo debe ingresar solo numeros.");
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
            else
            {
                MessageBox.Show("Para este campo debe ingresar solo numeros.");
            }
            return retorno;
        }
        #endregion

    }
}
