using System.Text.Json;
using RetoLisbet.Models;

namespace RetoLisbet.Services
{
    public class ServicioDatos
    {
        private readonly HttpClient _httpClient;

        public ServicioDatos(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Datos>> ObtenerDatosAsync()
        {
            var response = await _httpClient.GetAsync("https://randomuser.me/api/"); // URL de la API externa
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Datos>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
