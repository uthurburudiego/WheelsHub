using System.IO;
using WheelsHub;
using WheelsHub.Logica;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string nombre = @"\MisVehiculos.xml";
        string path = ruta + nombre;

        Console.WriteLine(path);
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        Auto auto = new Auto("Camaro", "1234565", eColores.Amarillo, eTipoVehiculo.Auto, 500000, 4, 5, eMarcasAutos.Chevrolet);
        Moto moto = new Moto("Fz", "1234567", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);
        Camion camion = new Camion("Camion", "1234567", eColores.Rojo, eTipoVehiculo.Camion, 500000, 2500, 5, eMarcasCamiones.Scania);
        Moto motoDos = new Moto("Fz", "1234337", eColores.Azul, eTipoVehiculo.Moto, 4000, 150, eTipoDeFrenos.Si, eMarcasMotos.Yamaha);

        vehiculos.Add(auto);
        vehiculos.Add(moto);
        vehiculos.Add(camion);

        foreach (Vehiculo vehiculo in vehiculos)
        {
            Console.WriteLine(vehiculo.ToString());
        }

    }
}