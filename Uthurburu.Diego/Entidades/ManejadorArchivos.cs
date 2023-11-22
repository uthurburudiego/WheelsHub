using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsHub;
using Newtonsoft.Json; 

namespace Entidades
{
    public class ManejadorArchivos
    {
        /// <summary>
        /// Obtiene la ruta completa a partir de una ruta relativa.
        /// </summary>
        /// <param name="rutaRelativa">Ruta relativa a convertir.</param>
        /// <returns>Ruta completa.</returns>
        public static string ObtenerPath(string rutaRelativa)
        { 

            return Path.GetFullPath(rutaRelativa);
        }
        /// <summary>
        /// Deserializa una lista de usuarios desde un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="rutaRelativa">Ruta relativa del archivo JSON.</param>
        /// <returns>Lista de usuarios deserializada.</returns>
        public static List<Usuario> DeserilizarUsuarios(string rutaRelativa) 
        {

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
              usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(rutaRelativa));

            }
            catch (Exception )
            {

                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {rutaRelativa}");
            }
            return usuarios;
        }
        /// <summary>
        /// Serializa una lista de usuarios y guarda el contenido en un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios a serializar.</param>
        /// <param name="rutaRelativa">Ruta relativa del archivo JSON.</param>
        public static void SerializarUsuarios(List<Usuario> usuarios, string rutaRelativa)
        {
            try
            {
                string usuariosJson = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(rutaRelativa, usuariosJson);
            }
            catch (Exception)
            {

                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {rutaRelativa}");
            }
        }
        /// <summary>
        /// Serializa una lista de nuevos usuarios y la agrega a la lista existente en un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="nuevosUsuarios">Lista de nuevos usuarios a serializar y agregar.</param>
        /// <param name="rutaRelativa">Ruta relativa del archivo JSON.</param>
        public static void SerializarRegistros(List<string> nuevosUsuarios, string rutaRelativa)
        {
            try
            {
                List<string> usuariosExistente = new List<string>();

                // Paso 1: Deserializar la lista existente desde el archivo JSON
                if (File.Exists(rutaRelativa))
                {
                    string contenidoExistente = File.ReadAllText(rutaRelativa);
                    usuariosExistente = JsonConvert.DeserializeObject<List<string>>(contenidoExistente);
                }
                usuariosExistente.AddRange(nuevosUsuarios);
                string registro = JsonConvert.SerializeObject(usuariosExistente, Formatting.Indented);
                File.WriteAllText(rutaRelativa, registro);
            }
            catch (Exception ex)
            {
                
                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {rutaRelativa}");
            }
        }
        /// <summary>
        /// Deserializa la lista de registros desde un archivo JSON en la ruta especificada.
        /// </summary>
        /// <param name="rutaRelativa">Ruta relativa del archivo JSON.</param>
        /// <returns>Lista de registros deserializada.</returns>
        public static List<string> DeserilizarRegistro(string rutaRelativa)
        {
            List<string> registro;
            try
            {
                registro = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(rutaRelativa));

            }
            catch (Exception )
            {

                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {rutaRelativa}");
            }
            return registro;

        }
    }
}
