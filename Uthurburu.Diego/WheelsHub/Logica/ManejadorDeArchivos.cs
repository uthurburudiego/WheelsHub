using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelsHub.Logica
{
    public class ManejadorDeArchivos
    {
        public static List<Auto> CargarAutos()
        {
            List<Auto> autos = new List<Auto>();

            if (File.Exists(CalcularRuta()))
            {
                string contenidoActual = File.ReadAllText(CalcularRuta());
                List<Auto> listaDeVehiculos = JsonConvert.DeserializeObject<List<Auto>>(contenidoActual);

                foreach (Auto vehiculo in listaDeVehiculos)
                {
                    if (vehiculo.TipoVehiculo == eTipoVehiculo.Auto)
                    {
                        autos.Add(vehiculo);
                    }
                }
            }
            return autos;

        }
        public static List<Moto> CargarMotos()
        {
            List<Moto> motos = new List<Moto>();

            if (File.Exists(CalcularRuta()))
            {
                string contenidoActual = File.ReadAllText(CalcularRuta());
                List<Moto> listaDeVehiculos = JsonConvert.DeserializeObject<List<Moto>>(contenidoActual);

                foreach (Moto vehiculo in listaDeVehiculos)
                {
                    if (vehiculo.TipoVehiculo == eTipoVehiculo.Moto)
                    {
                        motos.Add(vehiculo);
                    }
                }
            }

            return motos;
        }
        public static List<Camion> CargarCamiones()
        {
            List<Camion> camiones = new List<Camion>();

            if (File.Exists(CalcularRuta()))
            {
                string contenidoActual = File.ReadAllText(CalcularRuta());
                List<Camion> listaDeVehiculos = JsonConvert.DeserializeObject<List<Camion>>(contenidoActual);

                foreach (Camion vehiculo in listaDeVehiculos)
                {
                    if (vehiculo.TipoVehiculo == eTipoVehiculo.Camion)
                    {
                        camiones.Add(vehiculo);
                    }
                }
            }

            return camiones;
        }





        public static string CalcularRuta()
        {
            // Paso 1: Lee el archivo JSON existente
            string rutaRelativa = @"..\..\Datos\STOCK.json";
            string rutaAbsoluta = Path.GetFullPath(rutaRelativa);

            return rutaAbsoluta;
        }



    }
}
