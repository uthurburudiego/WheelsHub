using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheelsHub.Logica
{
    [Serializable]
    
    public class Auto : Vehiculo
    {
        #region Atributos
        private int cantidadPasajeros;
        private int cantidadPuertas;
        private eMarcasAutos marca;
        #endregion

        #region Constructores
        public Auto() : base() 
        {
            cantidadPasajeros = 0;
            cantidadPuertas = 0;
            marca = eMarcasAutos.Seleccionar;
        
        }
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
                if (Vehiculo.validarRango(value,"Ingrese una cantidad de pasajeros valida (1-10)", 1, 10)) 
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
                if (Vehiculo.validarRango(value, "Ingrese una cantidad de puertas valida (2-5)", 2, 5))
                {
                    this.cantidadPasajeros = value;
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
        public override string ObtenerDescripcion()
        {
            return $"{this.tipoVehiculo} - Marca: {this.marca} - Modelo: {this.modelo} - Color: {this.color} " +
                $"- Cantidad Puertas: {this.cantidadPuertas} - Capacidad de pasajeros: {this.cantidadPasajeros}" +
                $" - Costo: US${this.costo} ";
        }
        public override double CalcularCostoMantenimiento()
        {
            return this.Costo * 0.15;
        }

        public override string ToString()
        {
            return base.ToString() + $"- Marca: {Marca} - Cantidad Puertas: {CantidadPuertas} - Capacidad de pasajeros: {CantidadPasajeros}";
        }
        #endregion



    }
}

