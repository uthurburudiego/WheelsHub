using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsHub.Logica
{

    public class Camion : Vehiculo
    {
        #region Atributos

        private int tara;
        private int cantidadEjes;
        private eMarcasCamiones marca;
        #endregion

        #region Constructores

        public Camion() : base()
        {
            this.tara = 0;
            this.cantidadEjes = 0;
            this.marca = eMarcasCamiones.Seleccionar;
        }


        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo) : base(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.tara = 0;
            this.cantidadEjes = 0;
            this.marca = eMarcasCamiones.Scania;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara) : this(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.tara = tara;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara, int cantidadEjes) : this(modelo, numeroChasis, color, tipoVehiculo, costo, tara)
        {
            this.cantidadEjes = cantidadEjes;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara, int cantidadEjes, eMarcasCamiones marca) : this(modelo, numeroChasis, color, tipoVehiculo, costo, tara, cantidadEjes)
        {
            this.marca = marca;
        }
        #endregion

        #region Propiedades
        public int Tara
        {
            get { return this.tara; }
            set
            {
                if (value > 0)
                {
                    this.tara = value;
                }
            }
        }
        public int CantidadEjes
        {
            get { return this.cantidadEjes; }
            set
            {
                if (Funciones.ValidarRango(value, "Ingreso un valor erroneo para la cantidad de ejes.(2 - 10)", 2, 10))
                {
                    this.cantidadEjes = value;
                }
            }

        }
        public eMarcasCamiones Marca
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
            return "Conquista las carreteras con la potencia y robustez de nuestros camiones. Diseñados para enfrentar \nlos desafíos más exigentes, nuestros camiones combinan rendimiento, durabilidad y versatilidad. Ya \nsea transportando cargas pesadas o enfrentando terrenos difíciles, nuestros camiones están listos para \nel trabajo duro. Descubre la comodidad y la eficiencia en cada viaje, respaldados por la \nconfiabilidad que define a nuestros vehículos industriales. Prepárate para una experiencia de \nconducción que potenciará tu capacidad de carga y rendimiento.";
        }
        /// <summary>
        /// Calcula el costo de mantenimiento del vehículo.
        /// </summary>
        /// <remarks>
        /// Este método calcula el costo de mantenimiento del vehículo basado en el costo del vehículo.
        /// </remarks>
        /// <returns>El costo de mantenimiento calculado.</returns>
        public override double CalcularCostoMantenimiento()
        {
            return Costo * 0.3;
        }
        /// <summary>
        /// Devuelve una representación en forma de cadena del objeto Camion.
        /// </summary>
        /// <remarks>
        /// Este método devuelve una cadena que representa el objeto Camion y contiene información sobre su marca,
        /// modelo, tara y cantidad de ejes.
        /// </remarks>
        /// <returns>Una cadena que representa el objeto Camion.</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nMarca: {Marca} \nTara: {Modelo} \nCantidad Ejes: {CantidadEjes}";
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Camion)
            {
                retorno = (Camion)obj == this;
            }
            return retorno;
        }
        #endregion

    }
}
