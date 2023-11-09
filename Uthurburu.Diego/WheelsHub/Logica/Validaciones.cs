using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelsHub.Logica
{
    internal class Validaciones
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
        #endregion

    }
}
