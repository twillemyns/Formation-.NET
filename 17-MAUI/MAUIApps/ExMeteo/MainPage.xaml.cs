using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using ExMeteo.Models;
using ExMeteo.ViewModels;

namespace ExMeteo
{
	public partial class MainPage : ContentPage
	{


		public MainPage()
		{
			InitializeComponent();
			BindingContext = new WeatherViewModel();
			GetDataFromAPI();
		}

		private async Task GetDataFromAPI()
		{
			var requestUri =
				"https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,weather_code,wind_speed_10m&timeformat=unixtime";

			var client = new HttpClient();

			var response = await client.GetAsync(requestUri);

			var body = await response.Content.ReadAsStringAsync();

			var test = JsonSerializer.Deserialize<Weather>(body);

			var jsonObject = JsonNode.Parse(body);
			var current = jsonObject["current"];

			var temperature = current["temperature_2m"].GetValue<double>();
			var weatherCode = current["weather_code"].GetValue<int>();
			var windSpeed = current["wind_speed_10m"].GetValue<double>();
			var timestamp = current["timestamp"].GetValue<long>();

			var weather = new Weather()
			{
				Temperature = temperature,
				WeatherCode = weatherCode,
				WindSpeed = windSpeed,
				TimeStamp = timestamp
			};
			Console.WriteLine("test");
			Debug.WriteLine($"Temp: {weather.Temperature}");
		}

	}

}
