using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsHub.Logica
{
    [Serializable]
    public class Camion : Vehiculo
    {
        #region Atributos

        private int tara;
        private short cantidadEjes;
        private eMarcasCamiones marca;
        #endregion

        #region Constructores

        public Camion() : base()
        {
            this.tara = 0;
            this.cantidadEjes = 0;
            this.marca = eMarcasCamiones.Scania;

        }


        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo) :base(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.tara = 0;
            this.cantidadEjes = 0;
            this.marca = eMarcasCamiones.Scania;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara):this(modelo, numeroChasis, color, tipoVehiculo, costo)
        {
            this.tara = tara;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara, short cantidadEjes) : this(modelo, numeroChasis, color, tipoVehiculo, costo, tara)
        {
            this.cantidadEjes = cantidadEjes;
        }
        public Camion(string modelo, string numeroChasis, eColores color, eTipoVehiculo tipoVehiculo, double costo,
            int tara, short cantidadEjes, eMarcasCamiones marca) : this(modelo, numeroChasis, color, tipoVehiculo, costo, tara, cantidadEjes)
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
                if (Vehiculo.validarRango(value,"Ingreso un valor erroneo para la cantidad de ejes.(2 - 10)", 2, 10))
                {
                    this.tara = value;
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
        public override double CalcularCostoMantenimiento()
        {
            return Costo * 0.3;
        }
        public override string ObtenerDescripcion()
        {
            return $"{this.tipoVehiculo} - Marca: {this.marca} - Modelo: {this.modelo} - Color: {this.color} -" +
                $" Tara: {this.tara} - Cantidad Ejes: {this.cantidadEjes} - Costo: US${this.costo} ";
        }


        public override string ToString()
        {
            return base.ToString() + $"- Marca: {Marca} - Tara: {Modelo} - Cantidad Ejes: {CantidadEjes}"  ;
        }
        #endregion
    }

}
