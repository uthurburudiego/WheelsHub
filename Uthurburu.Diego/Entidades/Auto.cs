using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheelsHub.Logica
{
    
    
    public class Auto : Vehiculo
    {
        #region Atributos
        private int cantidadPasajeros;
        private int cantidadPuertas;
        private eMarcasAutos marca;
        #endregion

        #region Constructores
        public Auto() 
        { }

        public Auto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo) : base(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            cantidadPasajeros = 0;
            cantidadPuertas = 0;
            marca = eMarcasAutos.Seleccionar;
        }
        public Auto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
                    int cantidadPasajeros):this(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public Auto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
                    int cantidadPasajeros, int cantidadPuertas) : this(modelo, numeroChasis, color, tipoVehiculo, costo,cantidadPasajeros)
        {
            this.cantidadPuertas = cantidadPuertas;
        }
        public Auto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
                    int cantidadPasajeros, int cantidadPuertas, eMarcasAutos marca) : this(modelo, numeroChasis, color, tipoVehiculo, costo, cantidadPasajeros,cantidadPuertas)
        {
            this.marca = marca;
        }
        #endregion

        #region Propiedades
        public int CantidadPasajeros 
        {
            get { return this.cantidadPasajeros; }
            set 
            {
                if (Validaciones.ValidarRango(value,"Ingrese una cantidad de pasajeros valida (1-10)", 1, 10)) 
                { 
                    this.cantidadPasajeros = value;
                }
                
            }
            
        }
        public int CantidadPuertas 
        {
            get { return this.cantidadPuertas; }
            set
            {

                if (Validaciones.ValidarRango(value, "Ingrese una cantidad de puertas valida (2-5)", 2, 7))
                {
                    this.cantidadPuertas = value;
                }

            }
        }
        public eMarcasAutos Marca 
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene una descripción basada en el texto proporcionado.
        /// </summary>
        /// <param name="texto">El texto que se utilizará para la descripción.</param>
        /// <returns>Una cadena que representa la descripción basada en el texto proporcionado.</returns>
        public override string ObtenerDescripcion(string texto)
        {
            return texto;
        }
        /// <summary>
        /// Calcula el costo estimado de mantenimiento del vehículo.
        /// </summary>
        /// <returns>El costo estimado de mantenimiento del vehículo como un valor decimal.</returns>
        public override double CalcularCostoMantenimiento()
        {
            return this.Costo * 0.15;
        }
        /// <summary>
        /// Convierte el objeto Auto en una representación de cadena que incluye detalles específicos del Auto.
        /// </summary>
        /// <returns>Una cadena que representa el objeto Auto, incluyendo la marca, cantidad de puertas y capacidad de pasajeros.</returns>
        public override string ToString()
        {
            return base.ToString() + $"- Marca: {Marca} - Cantidad Puertas: {CantidadPuertas} - Capacidad de pasajeros: {CantidadPasajeros}";
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                retorno = (Auto)obj == this;
            }
            return retorno;
        }
            #endregion

    }
}

