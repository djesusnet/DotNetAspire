using System.Reflection.Metadata.Ecma335;
using WeatherApp.Web.Components.Pages;

namespace WeatherApp.Web
{
    public class WeatherApiClient
    {
        private readonly HttpClient _httpClient;

        public WeatherApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Weather.WeatherForecast[]?> GetWeatherForecastsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Weather.WeatherForecast[]>("weatherForecast");
        }
        
    }
}
