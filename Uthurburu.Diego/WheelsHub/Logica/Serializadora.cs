using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WheelsHub.Logica
{
    public class Serializadora
    {
        public static void EscribirXML(string path, List<Vehiculo> lista) 
        {
            using (StreamWriter sw = new StreamWriter(path))
            { 
                XmlSerializer ser = new XmlSerializer(typeof(List<Vehiculo>));
                ser.Serialize(sw, lista);           
            }
        }

        public static List<Vehiculo> LeerXML(string path) 
        {
            List<Vehiculo> lista;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Vehiculo>));
            
                lista =  (List<Vehiculo>)des.Deserialize(sr);
            }
            return lista;
        }

        public static void EscribirJson(string path, List<Vehiculo> lista)
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        
        }
        public static List<Vehiculo> LeerJson(string path)
        {
            List<Vehiculo> lista = null;
            try
            {
                string json = File.ReadAllText(path);  
                lista = JsonConvert.DeserializeObject<List<Vehiculo>>(json);
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.ToString());

            }

            return lista;
        
        }
       
  





    }
}
