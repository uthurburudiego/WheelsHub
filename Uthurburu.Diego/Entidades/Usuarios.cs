using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;

namespace WheelsHub
{
      
    public class Usuario
    {
        #region Atributos
        private string apellido;
        private string nombre;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;
        private DateTime ultimaConexion;
        #endregion

        #region Constructores
        public Usuario()
        { }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, string perfil)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
            this.ultimaConexion = new DateTime();
        }
        #endregion

        #region Propiedades
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public DateTime UltimaConexion { get => ultimaConexion; set => ultimaConexion = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve una cadena que representa el objeto actual.
        /// </summary>
        /// <returns>Cadena que representa el objeto actual.</returns>
        public override string ToString()
        {
            return $"Legajo: {this.legajo} - Perfil:{this.perfil} - Apellido: {this.apellido} - Nombre: {this.nombre} ";
        }
        /// <summary>
        /// Devuelve una cadena que representa el registro del usuario.
        /// </summary>
        /// <returns>Cadena que representa el registro del usuario.</returns>
        public string Registro()
        {

            return $"Usuario: [{this.correo}] -- Ultima coneción: [{this.ultimaConexion = DateTime.Now}]";
        
        }
        #endregion

    }

}
