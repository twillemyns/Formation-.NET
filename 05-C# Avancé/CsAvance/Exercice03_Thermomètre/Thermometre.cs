namespace Exercice03_Thermomètre;

internal class Thermometre
{
    private double _temperatureKelvin;

    public double TemperatureKelvin { get => _temperatureKelvin; set { _temperatureKelvin = value; } }

    public double TemperatureCelcius
    {
        get => _temperatureKelvin - 273.15;
        
        set
        {
            TemperatureKelvin = value + 273.15;
        }
    }

    public double TemperatureFahrenheit
    {
        get => (_temperatureKelvin - 273.15) * 1.8 + 32;

        set
        {
            TemperatureKelvin = (value - 32) * 1.8 + 273.15;
        }
    }

    public static Thermometre operator +(Thermometre a, double b)
    {
        a.TemperatureKelvin += b;
        return a;
    }

    public Thermometre(double temperature, UniteTemperature unite)
    {
        switch (unite)
        {
            case UniteTemperature.Celcius:
                TemperatureCelcius = temperature;
                break;
            case UniteTemperature.Fahrenheit:
                TemperatureFahrenheit = temperature;
                break;
            case UniteTemperature.Kelvin:
                TemperatureKelvin = temperature;
                break;
        }
    }

    
}

public enum UniteTemperature
{
    Celcius,
    Fahrenheit,
    Kelvin
}
