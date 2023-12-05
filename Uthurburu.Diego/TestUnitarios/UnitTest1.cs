using Entidades;
using WheelsHub;
using WheelsHub.Logica;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Prueba unitaria para verificar si dos instancias de la clase Moto son iguales.
        /// </summary>
        [TestMethod]
        public void TestMotosIguales()
        {
            //ARANGE
            Moto m1 = new Moto("Fz", "1234337", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);
            Moto m2 = new Moto("Fz", "1234337", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);

            //ACT
            bool prueba = m1 == m2;
            //ASSERT
            Assert.IsTrue(prueba);  
        }
        /// <summary>
        /// Prueba unitaria para verificar si dos instancias de la clase Moto son distintas.
        /// </summary>
        [TestMethod]
        public void TestMotosDistintas()
        {
            //ARANGE
            Moto m1 = new Moto("Fz", "1234567", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);
            Moto m2 = new Moto("Fz", "1234337", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);

            //ACT
            bool prueba = m1 == m2;
            //ASSERT
            Assert.IsFalse(prueba);
        }
        /// <summary>
        /// Prueba unitaria para verificar si un valor está dentro del rango especificado.
        /// </summary>
        [TestMethod]
        public void TestDentroDelRango()
        {
            //ARANGE
            short valorIngresado = 5;
            string mensajeError = "El valor ingresado esta fuera de rango";
            string titulo = "Test dentro del rango";
            int valorMinimo =  1;
            int valorMaximo = 10;

            //ACT
            bool prueba = Funciones.ValidarRango(valorIngresado, mensajeError, titulo ,valorMinimo, valorMaximo);
            //ASSERT
            Assert.IsTrue(prueba);
        }
        /// <summary>
        /// Prueba unitaria para verificar si un valor está fuera del rango especificado.
        /// </summary>
        [TestMethod]
        public void TestFueraDelRango()
        {
            //ARANGE
            short valorIngresado = 300;
            string mensajeError = "El valor ingresado esta fuera de rango";
            string titulo = "Test fuera del rango";
            int valorMinimo = 1;
            int valorMaximo = 10;

            //ACT
            bool prueba = Funciones.ValidarRango(valorIngresado, mensajeError,titulo , valorMinimo, valorMaximo);
            //ASSERT
            Assert.IsFalse(prueba);
        }
        /// <summary>
        /// Prueba unitaria para validar el parseo de un número desde una cadena.
        /// </summary>
        [TestMethod]
        public void TestValidarParse()
        {
            //ARANGE
            string numeroIngresado = "5";
            short numeroParseado;
            Funciones funciones= new Funciones();   

            //ACT
            bool prueba = funciones.validarNumero(numeroIngresado, out numeroParseado);
            //ASSERT
            Assert.IsTrue(prueba);
            Assert.AreEqual(numeroParseado, 5);
        }
        /// <summary>
        /// Prueba unitaria para validar el parseo de un número desde una cadena con error.
        /// </summary>
        [TestMethod]
        public void TestValidarParseError()
        {
            //ARANGE
            string numeroIngresado = "5g";
            short numeroParseado;
            Funciones funciones = new Funciones();

            //ACT
            bool prueba = funciones.validarNumero(numeroIngresado, out numeroParseado);
            //ASSERT
            Assert.IsFalse(prueba);
            
        }
    }
}