﻿using WheelsHub.Logica;
using System.Xml.Serialization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WheelsHub
{
    public abstract class Vehiculo
    {
        #region Atributos
        protected string modelo;
        protected string numeroChasis;
        protected eColores color;
        protected eTipoVehiculo tipoVehiculo;
        protected double costo;
        protected byte[] foto;
        
        #endregion

        #region Constructores
        public Vehiculo()
        {
            this.modelo = "";
            this.color = eColores.Seleccionar;
            this.tipoVehiculo = eTipoVehiculo.Seleccionar;
            this.costo = 0;
          
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
        public Vehiculo(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,byte[] foto) : this(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.foto = foto;
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
            set {this.costo = value;}
        }

        public byte[] Foto 
        {
            get { return this.foto;  }
            set { this.foto = value; }  
        }
        #endregion

        #region Metodos
       
        /// <summary>
        /// Calcula el costo de mantenimiento del vehículo.
        /// </summary>
        /// <remarks>
        /// El costo de mantenimiento se calcula como un porcentaje del costo del vehículo.
        /// </remarks>
        /// <returns>El costo de mantenimiento del vehículo.</returns>
        public virtual double CalcularCostoMantenimiento()
        {
            return Costo * 0.1; 
        }
        /// <summary>
        /// Obtiene una descripción basada en el texto proporcionado.
        /// </summary>
        /// <returns>Una cadena que representa la descripción basada en el texto proporcionado.</returns>
        public abstract string ObtenerDescripcion();
        /// <summary>
        /// Compara dos vehículos para verificar si tienen el mismo número de chasis.
        /// </summary>
        /// <param name="vehiculo1">El primer vehículo a comparar.</param>
        /// <param name="vehiculo2">El segundo vehículo a comparar.</param>
        /// <returns>
        ///   <c>true</c> si los vehículos tienen el mismo número de chasis; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.numeroChasis == vehiculo2.numeroChasis;
        }
        /// <summary>
        /// Compara dos vehículos para verificar si tienen números de chasis diferentes.
        /// </summary>
        /// <param name="vehiculo1">El primer vehículo a comparar.</param>
        /// <param name="vehiculo2">El segundo vehículo a comparar.</param>
        /// <returns>
        ///   <c>true</c> si los vehículos tienen números de chasis diferentes; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un vehículo a una lista de vehículos, verificando su existencia en la lista.
        /// </summary>
        /// <param name="lista">La lista de vehículos a la que se desea agregar el vehículo.</param>
        /// <param name="unVehiculo">El vehículo que se desea agregar a la lista.</param>
        /// <returns>True si el vehículo se agregó exitosamente a la lista, false si el vehículo ya existe en la lista.</returns>
        public static bool operator +(List<Vehiculo> lista, Vehiculo unVehiculo)
        {
            bool retorno = false;
            if (!lista.Contains(unVehiculo))
            {
                lista.Add(unVehiculo);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador - para eliminar un vehículo de una lista de vehículos, si existe en la lista.
        /// </summary>
        /// <param name="lista">La lista de vehículos de la que se desea eliminar el vehículo.</param>
        /// <param name="unVehiculo">El vehículo que se desea eliminar de la lista.</param>
        /// <returns>True si el vehículo se eliminó exitosamente de la lista, false si el vehículo no se encontraba en la lista.</returns>
        public static bool operator -(List<Vehiculo> lista, Vehiculo unVehiculo)
        {
            bool retorno = false;
            if (lista.Contains(unVehiculo))
            {
                lista.Remove(unVehiculo);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Devuelve una representación en forma de cadena del vehículo.
        /// </summary>
        /// <returns>Una cadena que contiene información sobre el tipo de vehículo,
        public override string ToString()
        {
            return $"{TipoVehiculo} \nModelo: {Modelo} \nColor: {Color} " + $"\nCosto: US${Costo} ";
        }
        /// <summary>
        /// Determina si el objeto actual es igual a otro objeto.
        /// </summary>
        /// <param name="obj">Objeto a comparar con el objeto actual.</param>
        /// <returns>
        /// <c>true</c> si el objeto actual es igual al parámetro <paramref name="obj"/>; 
        /// de lo contrario, <c>false</c>.
        /// </returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Vehiculo)
            {
                retorno = (Vehiculo)obj == this;
            }
            return retorno;
        }
        #endregion

    }
}
