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
    }
}
