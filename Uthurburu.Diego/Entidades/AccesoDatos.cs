using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WheelsHub;
using WheelsHub.Logica;

namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion; 
        }
        public AccesoDatos()
        { 
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }
        public bool PruebaConexion()
        { 
            bool result = false;
            try
            {
                this.conexion.Open();
                result = true;
            }
            catch (Exception)
            {


            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open )
                {
                    this.conexion.Close();

                }
            }
            return result;
        }
        public List<Usuario> ObtenerListaDatos()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Legajo, Apellido, Nombre, Correo, Clave, Perfil from Usuarios";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Legajo = (int)this.lector["Legajo"];
                    usuario.Apellido = this.lector["Apellido"].ToString();
                    usuario.Nombre = this.lector["Nombre"].ToString();
                    usuario.Correo = this.lector["Correo"].ToString();
                    usuario.Clave = this.lector["Clave"].ToString();
                    usuario.Perfil = this.lector["Perfil"].ToString();

                    lista.Add(usuario);
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {

                
            }
            finally 
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
        public List<Moto> ObtenerListaMoto()
        {
            List<Moto> lista = new List<Moto>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Chasis, Modelo, Color, TipoVehiculo, Costo, Cilindrada, FrenoABS, Marca from Vehiculos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    if ((int)this.lector["TipoVehiculo"] == 2)
                    {
                        Moto moto = new Moto();
                        moto.NumeroChasis = this.lector["Chasis"].ToString();
                        moto.Modelo = this.lector["Modelo"].ToString();
                        moto.Color = (eColores)this.lector["Color"];
                        moto.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        moto.Costo = (double)this.lector["Costo"];
                        moto.Cilindrada = (int)this.lector["Cilindrada"];
                        moto.FrenosABS = (eTipoDeFrenos)this.lector["FrenoABS"];
                        moto.Marca = (eMarcasMotos)this.lector["Marca"];

                        lista.Add(moto);
                    }
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }

            }
            return lista;

        }
        public bool AgregarMoto(Moto nuevaMoto)
        {
            
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Vehiculos (Chasis, Modelo, Color, TipoVehiculo, Costo, Cilindrada, FrenoABS, Marca) " +
                                           "VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @Cilindrada, @FrenoABS, @Marca)";
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@Chasis", nuevaMoto.NumeroChasis);
                this.comando.Parameters.AddWithValue("@Modelo", nuevaMoto.Modelo);
                this.comando.Parameters.AddWithValue("@Color", nuevaMoto.Color);
                this.comando.Parameters.AddWithValue("@TipoVehiculo", (int)nuevaMoto.TipoVehiculo);
                this.comando.Parameters.AddWithValue("@Costo", nuevaMoto.Costo);
                this.comando.Parameters.AddWithValue("@Cilindrada", nuevaMoto.Cilindrada);
                this.comando.Parameters.AddWithValue("@FrenoABS", (int)nuevaMoto.FrenosABS);
                this.comando.Parameters.AddWithValue("@Marca", (int)nuevaMoto.Marca);

                this.conexion.Open();
                int rowsAffected = this.comando.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, loguearla o mostrar un mensaje al usuario.
                return false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
        public List<Auto> ObtenerListaAuto()
        {
            List<Auto> lista = new List<Auto>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadPasajeros, Marca, CantidadPuertas from Vehiculos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    if ((int)this.lector["TipoVehiculo"] == 1)
                    {
                        Auto auto = new Auto();
                        auto.NumeroChasis = this.lector["Chasis"].ToString();
                        auto.Modelo = this.lector["Modelo"].ToString();
                        auto.Color = (eColores)this.lector["Color"];
                        auto.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        auto.Costo = (double)this.lector["Costo"];
                        auto.CantidadPuertas = (int)this.lector["CantidadPuertas"];
                        auto.CantidadPasajeros = (int)this.lector["CantidadPasajeros"];
                        auto.Marca = (eMarcasAutos)this.lector["Marca"];

                        lista.Add(auto);
                    }
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }

            }
            return lista;

        }
        public bool AgregarAuto(Auto auto)
        {
            try
            {
                this.conexion.Open();

                // Aquí, debes construir tu consulta SQL de inserción. 
                // Supongamos que la tabla en la base de datos se llama 'Vehiculos' y tiene columnas como 'Chasis', 'Modelo', 'Color', etc.
                string consulta = "INSERT INTO Vehiculos (Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadPasajeros, Marca, CantidadPuertas) " +
                                  "VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @CantidadPasajeros, @Marca, @CantidadPuertas)";

                using (SqlCommand cmd = new SqlCommand(consulta, this.conexion))
                {
                    // Agrega los parámetros a la consulta para evitar la inyección de SQL.
                    cmd.Parameters.AddWithValue("@Chasis", auto.NumeroChasis);
                    cmd.Parameters.AddWithValue("@Modelo", auto.Modelo);
                    cmd.Parameters.AddWithValue("@Color", auto.Color);
                    cmd.Parameters.AddWithValue("@TipoVehiculo", (int)auto.TipoVehiculo);
                    cmd.Parameters.AddWithValue("@Costo", auto.Costo);
                    cmd.Parameters.AddWithValue("@CantidadPasajeros", auto.CantidadPasajeros);
                    cmd.Parameters.AddWithValue("@Marca", (int)auto.Marca);
                    cmd.Parameters.AddWithValue("@CantidadPuertas", auto.CantidadPuertas);

                    // Ejecuta la consulta de inserción.
                    int rowsAffected = this.comando.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tu lógica.
                return false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
        public bool AgregarCamion(Camion nuevoCamion)
        {

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Vehiculos (Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadEjes, Marca, Marca) " +
                                           "VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @Tara, @CantidadEjes, @Marca)";
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@Chasis", nuevoCamion.NumeroChasis);
                this.comando.Parameters.AddWithValue("@Modelo", nuevoCamion.Modelo);
                this.comando.Parameters.AddWithValue("@Color", nuevoCamion.Color);
                this.comando.Parameters.AddWithValue("@TipoVehiculo", (int)nuevoCamion.TipoVehiculo);
                this.comando.Parameters.AddWithValue("@Costo", nuevoCamion.Costo);
                this.comando.Parameters.AddWithValue("@Tara", nuevoCamion.Tara);
                this.comando.Parameters.AddWithValue("@CantidadEjes", nuevoCamion.CantidadEjes);
                this.comando.Parameters.AddWithValue("@Marca", (int)nuevoCamion.Marca);

                this.conexion.Open();
                int rowsAffected = this.comando.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, loguearla o mostrar un mensaje al usuario.
                return false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
        public List<Camion> ObtenerListaCamion()
        {
            List<Camion> lista = new List<Camion>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadEjes, Tara, Marca from Vehiculos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    if ((int)this.lector["TipoVehiculo"] == 3)
                    {
                        Camion camion = new Camion();
                        camion.NumeroChasis = this.lector["Chasis"].ToString();
                        camion.Modelo = this.lector["Modelo"].ToString();
                        camion.Color = (eColores)this.lector["Color"];
                        camion.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        camion.Costo = (double)this.lector["Costo"];
                        camion.CantidadEjes = (int)this.lector["CantidadEjes"];
                        camion.Tara = (int)this.lector["Tara"];
                        camion.Marca = (eMarcasCamiones)this.lector["Marca"];

                        lista.Add(camion);
                    }
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
        public void BorrarVehiculo(string numeroChasis)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena_conexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;

                        // Utiliza una instrucción DELETE para borrar un camión de la base de datos
                        comando.CommandText = "DELETE FROM Vehiculos WHERE Chasis = @Chasis";

                        // Agrega parámetro para evitar problemas de SQL Injection
                        comando.Parameters.AddWithValue("@Chasis", numeroChasis);

                        // Ejecuta la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Se borró el camión de la base de datos.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró el camión con el número de chasis especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al borrar camión de la base de datos: {ex.Message}");
            }
        }

        public List<Vehiculo> ObtenerListaVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            try
            {
                

                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadEjes, Tara,CantidadPasajeros, Marca, CantidadPuertas, Cilindrada, FrenoABS from Vehiculos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();

                while (this.lector.Read())
                {
                    if ((int)this.lector["TipoVehiculo"] == 3)
                    {
                        Camion camion = new Camion();
                        camion.NumeroChasis = this.lector["Chasis"].ToString();
                        camion.Modelo = this.lector["Modelo"].ToString();
                        camion.Color = (eColores)this.lector["Color"];
                        camion.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        camion.Costo = (double)this.lector["Costo"];
                        camion.CantidadEjes = (int)this.lector["CantidadEjes"];
                        camion.Tara = (int)this.lector["Tara"];
                        camion.Marca = (eMarcasCamiones)this.lector["Marca"];

                        lista.Add(camion);
                    }
                    if ((int)this.lector["TipoVehiculo"] == 2)
                    {
                        Moto moto = new Moto();
                        moto.NumeroChasis = this.lector["Chasis"].ToString();
                        moto.Modelo = this.lector["Modelo"].ToString();
                        moto.Color = (eColores)this.lector["Color"];
                        moto.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        moto.Costo = (double)this.lector["Costo"];
                        moto.Cilindrada = (int)this.lector["Cilindrada"];
                        moto.FrenosABS = (eTipoDeFrenos)this.lector["FrenoABS"];
                        moto.Marca = (eMarcasMotos)this.lector["Marca"];

                        lista.Add(moto);
                    }
                    if ((int)this.lector["TipoVehiculo"] == 1)
                    {
                        Auto auto = new Auto();
                        auto.NumeroChasis = this.lector["Chasis"].ToString();
                        auto.Modelo = this.lector["Modelo"].ToString();
                        auto.Color = (eColores)this.lector["Color"];
                        auto.TipoVehiculo = (eTipoVehiculo)this.lector["TipoVehiculo"];
                        auto.Costo = (double)this.lector["Costo"];
                        auto.CantidadPuertas = (int)this.lector["CantidadPuertas"];
                        auto.CantidadPasajeros = (int)this.lector["CantidadPasajeros"];
                        auto.Marca = (eMarcasAutos)this.lector["Marca"];

                        lista.Add(auto);
                    }
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }

    }
}
