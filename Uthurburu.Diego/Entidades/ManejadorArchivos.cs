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
        public static string ObtenerPath(string rutaRelativa)
        { 

            return Path.GetFullPath(rutaRelativa);
        }

        public static List<Usuario> DeserilizarUsuarios(string rutaRelativa) 
        {
            List<Usuario> usuarios;
            try
            {
              usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(rutaRelativa));

            }
            catch (Exception ex)
            {

                throw;
            }

            return usuarios;

        }


        public static void SerializarUsuarios(List<Usuario> usuarios, string rutaRelativa)
        {
            try
            {
                string usuariosJson = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText(rutaRelativa, usuariosJson);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
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

                // Paso 2: Agregar la nueva lista a la lista existente
                usuariosExistente.AddRange(nuevosUsuarios);

                // Paso 3: Serializar la lista combinada y guardarla en el archivo JSON
                string registro = JsonConvert.SerializeObject(usuariosExistente, Formatting.Indented);
                File.WriteAllText(rutaRelativa, registro);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                throw;
            }
        }
        public static List<string> DeserilizarRegistro(string rutaRelativa)
        {
            List<string> registro;
            try
            {
                registro = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(rutaRelativa));

            }
            catch (Exception ex)
            {

                throw;
            }

            return registro;

        }
    }
}
