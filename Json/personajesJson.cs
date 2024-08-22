using Personajes;
using FabricaPersonajes;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace EspacioJson
{

    public class PersonajesJson{
        public static void GuardarPersonajes(List<Personaje> Lista, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(Lista, options);
            File.WriteAllText(fileName,json);
        }
        public static List<Personaje> LeerPersonajes(string fileName)
        {
            if (File.Exists(fileName))
            {
                String jsonString = File.ReadAllText(fileName);
                List<Personaje> personajesDeserializados = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
                return personajesDeserializados;
            }else
            {
                System.Console.WriteLine("El archivo de nombre: " + fileName + " no existe");
                return null;
            }
        }
         public static bool Existe(string fileName)
        {
            return File.Exists(fileName);
        }


    }


}