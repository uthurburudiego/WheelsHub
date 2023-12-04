using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsHub;
using Newtonsoft.Json; 

namespace Entidades
{
    public class ManejadorArchivos<T> : ISerializadora<T>
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
        /// Serializa datos y los guarda en un archivo JSON, fusionándolos con los datos existentes si el archivo ya existe.
        /// </summary>
        /// <param name="datos">Datos a serializar y guardar.</param>
        /// <param name="path">Ruta del archivo JSON donde se guardarán los datos.</param>
        /// <typeparam name="T">Tipo de datos a serializar.</typeparam>
        /// <exception cref="ExcepcionArchivos">
        /// Se lanza cuando no se puede encontrar el archivo en la ruta especificada o no se pueden guardar los registros.
        /// </exception>
        public void Serializar(T datos, string path)
        {
            try
            {
                List<string> usuariosExistente = new List<string>();

                // Paso 1: Deserializar la lista existente desde el archivo JSON
                if (File.Exists(path))
                {
                    string contenidoExistente = File.ReadAllText(path);
                    usuariosExistente = JsonConvert.DeserializeObject<List<string>>(contenidoExistente);
                }
                usuariosExistente.AddRange((IEnumerable<string>)datos); 
                string registro = JsonConvert.SerializeObject(usuariosExistente, Formatting.Indented);
                File.WriteAllText(path, registro);
            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {path}\nNo se pudo guardar los registros.", ex);
            }
        }
        /// <summary>
        /// Deserializa los datos desde un archivo JSON en la ruta especificada y los devuelve como un objeto del tipo T.
        /// </summary>
        /// <param name="path">Ruta del archivo JSON desde el cual se deserializarán los datos.</param>
        /// <typeparam name="T">Tipo de datos a deserializar.</typeparam>
        /// <returns>Objeto del tipo T que representa los datos deserializados.</returns>
        /// <exception cref="ExcepcionArchivos">
        /// Se lanza cuando no se puede encontrar el archivo en la ruta especificada o no se pueden obtener los datos.
        /// </exception>
        public T Deserializar(string path)
        {
            T usuarios = default(T);
            try
            {
                usuarios = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));

            }
            catch (Exception ex)
            {

                throw new ExcepcionArchivos($"ERROR no se pudo encontrar el archivo en la ruta: {path}\nNo se pudo obtener usuarios.", ex);
            }
            return usuarios;
        }
    }
}
