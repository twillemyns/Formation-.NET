using Exercice03_Thermomètre;

var th = new Thermometre(10, UniteTemperature.Celcius);

Console.WriteLine("Temp Celcius : " + th.TemperatureCelcius);
Console.WriteLine("Temp Kelvin : " + th.TemperatureKelvin);
Console.WriteLine("Temp Fahrenheit : " + th.TemperatureFahrenheit);

th = th + 20.5;

Console.WriteLine(th.TemperatureKelvin);