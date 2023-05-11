using Newtonsoft.Json;
using System.Globalization;
using static System.Net.WebRequestMethods;
await Weather.GetDataFromOpenWeatherMap();
Console.WriteLine(Weather.Icon + " " + Weather.Description  + " " + Weather.Temperature);
static class Weather
{
    public static string Temperature { get; set; } = string.Empty;
    public static string Description { get; set; } = string.Empty;
    public static string Icon { get; set; } = string.Empty;
    public static async Task GetDataFromOpenWeatherMap()
    {
        using (HttpClient client = new())
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=moscow,ru&appid=17f74e0477580d172ff3511a555e801e&units=metric&lang=ru";
            HttpRequestMessage request = new(HttpMethod.Get, url);
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            dynamic weather = JsonConvert.DeserializeObject(body);
            if (weather != null)
            {
                double temperature = weather.main.temp;
                Temperature = temperature >= 0 ? "+" + temperature + "C" : "-" + temperature + "C";
                string description = weather.weather[0].description;
                Description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(description);
                Icon = weather.weather[0].icon;
            }
        }
    }
}