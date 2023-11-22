using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsHub.Logica
{
    
    public class Moto : Vehiculo
    {
        #region Atributos

        private int cilindrada;
        private eTipoDeFrenos frenosABS;
        private eMarcasMotos marca;

        #endregion

        #region Constructores
        public Moto(): base()
        { 
            this.cilindrada = 0;
            this.frenosABS = eTipoDeFrenos.Seleccionar;
            this.marca = eMarcasMotos.Seleccionar;
        }

        public Moto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo) :base(modelo, numeroChasis, color, tipoVehiculo, costo)
        { 
            this.cilindrada = 0;
            this.frenosABS = eTipoDeFrenos.Seleccionar;
            this.marca = eMarcasMotos.Seleccionar;
        }
        public Moto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
           int cilindrada) :this(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.cilindrada = cilindrada;
        }
        public Moto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
           int cilindrada, eTipoDeFrenos frenosABS) : this(modelo,numeroChasis,color, tipoVehiculo, costo, cilindrada)
        {
            this.frenosABS = frenosABS;
        }
        public Moto(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
           int cilindrada, eTipoDeFrenos frenosABS, eMarcasMotos marca) : this(modelo, numeroChasis, color, tipoVehiculo, costo, cilindrada, frenosABS)
        {
            this.marca = marca ;
        }
        #endregion

        #region Propiedades
        public int Cilindrada 
        { 
            get { return this.cilindrada; }
            set 
            {
                if (Funciones.ValidarRango(value, "Supero rango valido (50-3000), se guardara como valor por defecto 0", 50, 3000))
                {
                    this.cilindrada = value;
                }
            }
        }
        public eTipoDeFrenos FrenosABS 
        {
            get { return this.frenosABS; }
            set { this.frenosABS = value; } 
        }
        public eMarcasMotos Marca
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
            return "Experimenta la libertad en su máxima expresión con nuestra excepcional línea de motocicletas. \nDesde el rugido del motor hasta la elegancia en el diseño, nuestras motos están diseñadas para ofrecer \nemociones auténticas en cada viaje. Descubre la perfecta combinación de potencia, estilo y tecnología \nque redefine la experiencia de conducción en dos ruedas. ¡Haz que cada viaje sea una aventura \ninolvidable con nuestras extraordinarias motocicletas!";
        }
        /// <summary>
        /// Calcula el costo de mantenimiento específico para este Camión.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo de mantenimiento del Camión, que es un 30% del costo total del Camión.
        /// </remarks>
        /// <returns>El costo de mantenimiento del Camión.</returns>
        public override double CalcularCostoMantenimiento()
        {
            return Costo * 0.3;
        }
        /// <summary>
        /// Devuelve una representación en cadena del objeto actual, incluyendo detalles específicos de la clase derivada.
        /// </summary>
        /// <returns>Cadena que representa el objeto actual.</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nMarca: {Marca} \nCilindrada: {Cilindrada} \nFrenos ABS: {FrenosABS}";
        }
        /// <summary>
        /// Determina si el objeto actual es igual a otro objeto del mismo tipo.
        /// </summary>
        /// <param name="obj">Objeto con el que se va a comparar el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Moto)
            {
                retorno = (Moto)obj == this;
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
