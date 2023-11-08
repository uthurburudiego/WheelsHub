using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using static System.Windows.Forms.AxHost;
using WheelsHub.Logica;
using System.Xml.Serialization;

namespace WheelsHub
{
    [Serializable]
    [XmlInclude(typeof(Camion))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Auto))]
    public class Vehiculo
    {
        #region Atributos
        protected string modelo;
        protected string numeroChasis;
        protected eColores color;
        protected eTipoVehiculo tipoVehiculo;
        protected double costo;
        //protected List<Vehiculo> vehiculoList;
        #endregion

        #region Constructores
        public Vehiculo()
        {
            this.numeroChasis = "";
            this.modelo = "Sin detalles";
            this.color = eColores.Seleccionar;
            this.tipoVehiculo = eTipoVehiculo.Seleccionar;
            this.costo = 0;
           // this.vehiculoList = new List<Vehiculo>();
        }
        public Vehiculo(string  modelo):this() 
        {
            this.modelo=modelo;
        }
        public Vehiculo(string modelo, string numeroChasis):this (modelo) 
        {
            this.numeroChasis = numeroChasis;
        }
        public Vehiculo(string modelo, string numeroChasis, eColores color): this(modelo, numeroChasis)
        { 
            this.color = color;
        }
        public Vehiculo(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo) : this(modelo, numeroChasis, color)
        { 
            this.tipoVehiculo = tipoVehiculo;
        }
        public Vehiculo(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo) : this(modelo, numeroChasis, color, tipoVehiculo)
        {
            this.costo = costo;
        }
        #endregion

        #region Propiedades
        public string Modelo 
        {
            get { return this.modelo; }
            set { this.modelo = value; } 
        }
        public string NumeroChasis 
        {
            get { return this.numeroChasis; }
            set
            {
                if (value.Length <= 17)
                {
                    this.numeroChasis = value;
                }
                else 
                {
                    MessageBox.Show("El número de chasis debe tener una longitud de 17 caracteres.");
                }
            }
        }
        public eColores Color 
        { 
            get { return this.color; }
            set { this.color = value; }
        }
        public eTipoVehiculo TipoVehiculo
        {
            get { return this.tipoVehiculo; }
            set { this.tipoVehiculo= value; }
        }
        public double Costo
        {
            get { return this.costo; }
            set
            {
                if (value >= 0)
                {
                    this.costo = value;
                }
            }
        }
        #endregion

        #region Metodos
        public static bool validarRango(double valorIngresado,string mensajeError, int valorMinimo, int valorMaximo)
        { 
            bool retorno = false ;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError); }
            return retorno;
        }
        public static bool validarRango(int valorIngresado, string mensajeError, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError); }
            return retorno;
        }
        public static bool validarRango(short valorIngresado, string mensajeError, int valorMinimo, int valorMaximo)
        {
            bool retorno = false;
            if (valorIngresado >= valorMinimo && valorIngresado <= valorMaximo)
            {
                retorno = true;
            }
            else { MessageBox.Show(mensajeError); }
            return retorno;
        }
        public virtual double CalcularCostoMantenimiento()
        {
            return Costo * 0.1; 
        }
        public virtual string ObtenerDescripcion() 
        {
            return "";
        
        }


        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.numeroChasis == vehiculo2.numeroChasis;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        public override string ToString()
        {
            return $"{TipoVehiculo} - Modelo: {Modelo} - Color: {Color} " + $" - Costo: US${Costo} ";
        }
        #endregion

    }
}
