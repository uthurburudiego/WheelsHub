﻿using System;
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
        public Auto() :base()
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
            set {this.cantidadPasajeros = value; }
            
        }
        public int CantidadPuertas 
        {
            get { return this.cantidadPuertas; }
            set {this.cantidadPuertas = value;}
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
        public override string ObtenerDescripcion()
        {
            return "Descubre el confort y la elegancia en cada viaje a bordo de nuestros excepcionales autos. \nDiseñados para ofrecer un equilibrio perfecto entre rendimiento y estilo, nuestros autos te brindan \nuna experiencia de conducción única. Desde la potencia del motor hasta los detalles de lujo en el \ninterior, cada momento al volante se convierte en un placer. Explora la carretera con confianza y \nestilo a través de la combinación perfecta de innovación y rendimiento que define a nuestros autos.";
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
            return base.ToString() + $"\nMarca: {Marca} \nCantidad Puertas: {CantidadPuertas} \nCapacidad de pasajeros: {CantidadPasajeros}";
        }
        /// <summary>
        /// Compara el objeto actual con otro objeto para determinar si son iguales.
        /// </summary>
        /// <param name="obj">El objeto a comparar con el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto proporcionado, False en caso contrario.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                retorno = (Auto)obj == this;
            }
            return retorno;
        }
        /// <summary>
        /// Devuelve un código hash para el objeto actual.
        /// </summary>
        /// <returns>Código hash del objeto.</returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}

