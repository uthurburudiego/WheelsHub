using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WheelsHub;

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


    }
}
