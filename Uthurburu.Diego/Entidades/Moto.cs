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
                if (Funciones.ValidarRango(value,"Ingreso un valor de cilindrada fuera de rango.(50 - 3000)", 50, 3000))
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

        public override string ToString()
        {
            return base.ToString() + $"\nMarca: {Marca} \nCilindrada: {Cilindrada} \nFrenos ABS: {FrenosABS}";
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Moto)
            {
                retorno = (Moto)obj == this;
            }
            return retorno;
        }

            #endregion
    }
}
