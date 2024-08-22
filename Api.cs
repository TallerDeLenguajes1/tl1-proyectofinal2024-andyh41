using System.Text.Json;
using Microsoft.VisualBasic;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace Api
{
    class Tirardados
    {
        public static async Task<int> TraerInfoAPI() 
        {
            try
            {
                HttpClient cliente = new HttpClient();
                var url = "https://www.dejete.com/api?nbde=1&tpde=6";
                HttpResponseMessage respuesta = await cliente.GetAsync(url);
                respuesta.EnsureSuccessStatusCode();

                string responseBody = await respuesta.Content.ReadAsStringAsync();
                var Tirados = JsonSerializer.Deserialize<List<Tirar>>(responseBody, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
    
                int resultado=0;
                foreach (var eldado in Tirados)
                {
                   resultado = eldado.Value;
                   
                }
                return resultado;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return 0;
            }

        }

    }

    public class Tirar
    {
        [JsonPropertyName("id")]
        public int Idd { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

}