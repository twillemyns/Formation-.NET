namespace ExMeteo.Models;

public class Weather
{
	public long TimeStamp { get; set; }

	public double Temperature { get; set; }

	public int WeatherCode { get; set; }

	public double WindSpeed { get; set; }
}