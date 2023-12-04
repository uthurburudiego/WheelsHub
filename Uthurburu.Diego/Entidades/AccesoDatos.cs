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
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region Constructores
        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }
        #endregion

        #region Metodos
        // <summary>
        /// Realiza una prueba de conexión a la base de datos.
        /// </summary>
        /// <returns>True si la conexión es exitosa, de lo contrario, False.</returns>
        /// <exception cref="ExcepcionBaseDatosError">Se lanza cuando no se puede establecer la conexión con la base de datos.</exception>
        public bool PruebaConexion()
        {
            bool result = false;
            try
            {
                this.conexion.Open();
                result = true;
            }
            catch (Exception ex)
            {

                throw new ExcepcionBaseDatosError("No se pudo conectar con la base de datos", ex);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();

                }
            }
            return result;
        }
        /// <summary>
        /// Obtiene una lista de vehículos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de vehículos.</returns>
        /// <exception cref="ExcepcionBaseDatosError">Se lanza cuando ocurre un error en la base de datos.</exception>
        public List<Vehiculo> ObtenerListaVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            try
            {

                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select Chasis, Modelo, Color, TipoVehiculo, Costo, CantidadEjes, Tara,CantidadPasajeros, Marca, CantidadPuertas, Cilindrada, FrenoABS, Foto from Vehiculos";
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
                        if (this.lector["Foto"] != DBNull.Value)
                            camion.Foto = (byte[])this.lector["Foto"];

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
                        if (this.lector["Foto"] != DBNull.Value)
                            moto.Foto = (byte[])this.lector["Foto"];

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
                        if (this.lector["Foto"] != DBNull.Value)
                            auto.Foto = (byte[])this.lector["Foto"];

                        lista.Add(auto);
                    }
                }
                this.lector.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ExcepcionBaseDatosError("ERROR, no se pudo obtener lista de vehiculos de la base de datos", ex);
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
     
        /// <summary>
        /// Verifica si ya existe un vehículo con el mismo número de chasis en la base de datos.
        /// </summary>
        /// <param name="numeroChasis">Número de chasis a verificar.</param>
        /// <returns>True si ya existe un vehículo con el mismo número de chasis, False en caso contrario.</returns>
        public bool VehiculoExiste(string numeroChasis)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena_conexion))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Vehiculos WHERE Chasis = @Chasis";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Chasis", numeroChasis);

                        int count = (int)command.ExecuteScalar();

                        return count > 0; // Retorna true si ya existe un vehículo con el mismo número de chasis.
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ExcepcionBaseDatosError("No se pudo conectar con la Base de Datos", ex);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
        /// <summary>
        /// Elimina un vehículo de la base de datos utilizando el número de chasis.
        /// </summary>
        /// <param name="numeroChasis">Número de chasis del vehículo a eliminar.</param>
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
        /// <summary>
        /// Realiza la operación de alta o modificación de un vehículo en la base de datos.
        /// </summary>
        /// <typeparam name="T">Tipo de vehículo que hereda de la clase base Vehiculo.</typeparam>
        /// <param name="nuevoVehiculo">Instancia del nuevo vehículo a agregar o modificar.</param>
        /// <param name="comando">Comando que indica la operación a realizar (INSERT o UPDATE).</param>
        /// <returns>True si la operación se realizó correctamente; de lo contrario, false.</returns>
        /// <exception cref="ExcepcionBaseDatosError">Se produce cuando ocurre un error durante la interacción con la base de datos.</exception>
        public bool AltaModificacionVehiculo<T>(T nuevoVehiculo, string comando) where T : Vehiculo
        {
       
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = ComandText(nuevoVehiculo, comando);

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@Chasis", nuevoVehiculo.NumeroChasis);
                this.comando.Parameters.AddWithValue("@Modelo", nuevoVehiculo.Modelo);
                this.comando.Parameters.AddWithValue("@Color", nuevoVehiculo.Color);
                this.comando.Parameters.AddWithValue("@TipoVehiculo", (int)nuevoVehiculo.TipoVehiculo);
                this.comando.Parameters.AddWithValue("@Costo", nuevoVehiculo.Costo);
                this.comando.Parameters.AddWithValue("@Foto", nuevoVehiculo.Foto);

                // Agregar parámetros específicos de cada tipo de vehículo
                if (nuevoVehiculo is Moto moto)
                {
                    this.comando.Parameters.AddWithValue("@Cilindrada", moto.Cilindrada);
                    this.comando.Parameters.AddWithValue("@FrenoABS", (int)moto.FrenosABS);
                    this.comando.Parameters.AddWithValue("@Marca", (int)moto.Marca);
                }
                else if (nuevoVehiculo is Auto auto)
                {
                    this.comando.Parameters.AddWithValue("@CantidadPasajeros", auto.CantidadPasajeros);
                    this.comando.Parameters.AddWithValue("@CantidadPuertas", auto.CantidadPuertas);
                    this.comando.Parameters.AddWithValue("@Marca", (int)auto.Marca);
                }
                else if (nuevoVehiculo is Camion camion)
                {
                    this.comando.Parameters.AddWithValue("@Tara", camion.Tara);
                    this.comando.Parameters.AddWithValue("@CantidadEjes", camion.CantidadEjes);
                    this.comando.Parameters.AddWithValue("@Marca", (int)camion.Marca);
                }

                this.conexion.Open();
                int rowsAffected = this.comando.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new ExcepcionBaseDatosError("ERROR, no se pudo agregar un vehículo en la base de datos.", ex);
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }
        /// <summary>
        /// Genera un comando SQL dinámico para realizar operaciones de INSERT o UPDATE en la tabla Vehiculos
        /// según el tipo de vehículo y el comando especificado.
        /// </summary>
        /// <param name="vehiculo">Instancia del vehículo para el cual se generará el comando.</param>
        /// <param name="comando">Comando que indica la operación a realizar (INSERT o UPDATE).</param>
        /// <returns>Cadena de texto con el comando SQL generado.</returns>
        /// <exception cref="ArgumentException">Se produce cuando el tipo de vehículo o comando no es reconocido.</exception>
        private string ComandText(Vehiculo vehiculo, string comando)
        {
            StringBuilder sb = new StringBuilder();

            if (vehiculo is Vehiculo)
            {
                if (comando.ToUpper() == "UPDATE")
                {
                    // Comando UPDATE
                    sb.Append($"{comando} Vehiculos SET Modelo = @Modelo, Color = @Color, TipoVehiculo = @TipoVehiculo, Costo = @Costo, Foto = @Foto");

                    switch (vehiculo.TipoVehiculo)
                    {
                        case eTipoVehiculo.Moto:
                            sb.Append(", Cilindrada = @Cilindrada, FrenoABS = @FrenoABS, Marca = @Marca");
                            break;
                        case eTipoVehiculo.Auto:
                            sb.Append(", CantidadPasajeros = @CantidadPasajeros, Marca = @Marca, CantidadPuertas = @CantidadPuertas");
                            break;
                        case eTipoVehiculo.Camion:
                            sb.Append(", Tara = @Tara, CantidadEjes = @CantidadEjes, Marca = @Marca");
                            break;
                    }
                    sb.Append(" WHERE Chasis = @Chasis");
                }
                else if (comando.ToUpper() == "INSERT")
                {
                    // Comando INSERT
                    sb.Append($"{comando} Vehiculos (Chasis, Modelo, Color, TipoVehiculo, Costo, Foto");

                    switch (vehiculo.TipoVehiculo)
                    {
                        case eTipoVehiculo.Moto:
                            sb.Append(", Cilindrada, FrenoABS, Marca");
                            sb.Append(") VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @Foto");
                            sb.Append(", @Cilindrada, @FrenoABS, @Marca");
                            break;
                        case eTipoVehiculo.Auto:
                            sb.Append(", CantidadPasajeros, Marca, CantidadPuertas");
                            sb.Append(") VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @Foto");
                            sb.Append(", @CantidadPasajeros, @Marca, @CantidadPuertas");

                            break;
                        case eTipoVehiculo.Camion:
                            sb.Append(", Tara, CantidadEjes, Marca");
                            sb.Append(") VALUES (@Chasis, @Modelo, @Color, @TipoVehiculo, @Costo, @Foto");
                            sb.Append(", @Tara, @CantidadEjes, @Marca");
                            break;
                    }
                    sb.Append(")");
                }
                else
                {
                    throw new ArgumentException("Tipo de comando no reconocido.", nameof(comando));
                }
            }
            else
            {
                throw new ArgumentException("Tipo de vehículo no reconocido.", nameof(vehiculo));
            }

            return sb.ToString();
        }
    }
    #endregion
}
