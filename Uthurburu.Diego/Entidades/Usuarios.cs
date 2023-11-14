using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Perfil { get => perfil; set => perfil = value; }



    }

}
