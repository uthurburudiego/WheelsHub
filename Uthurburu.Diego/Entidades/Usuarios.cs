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
        private string apellido;
        private string nombre;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;
        private DateTime ultimaConexion;

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

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public DateTime UltimaConexion { get => ultimaConexion; set => ultimaConexion = value; }

        public override string ToString()
        {
            return $"Legajo: {this.legajo} - Perfil:{this.perfil} - Apellido: {this.apellido} - Nombre: {this.nombre} ";
        }

        public string Registro()
        {

            return $"Usuario: [{this.correo}] -- Ultima coneción: [{this.ultimaConexion = DateTime.Now}]";
        
        }

    }

}
