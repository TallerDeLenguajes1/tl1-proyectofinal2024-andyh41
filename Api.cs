using System.Text.Json;
using Microsoft.VisualBasic;
using System.Text.Json.Serialization;

namespace Api
{
    class Tirardados
    {
        public static async Task<Tirar> TraerInfoAPI() 
        {
            try
            {
                HttpClient cliente = new HttpClient();
                var url = "https://www.dejete.com/api?nbde=1&tpde=6";
                HttpResponseMessage respuesta = await cliente.GetAsync(url);
                respuesta.EnsureSuccessStatusCode();

                string responseBody = await respuesta.Content.ReadAsStringAsync();
                var Tirar = JsonSerializer.Deserialize<Tirar>(responseBody, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
    
                if (Tirar != null)
                {
                    return Tirar;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return null;
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