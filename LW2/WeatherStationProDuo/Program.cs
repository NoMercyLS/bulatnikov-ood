using System;
using WeatherStationProDuo.WeatherData;

namespace WeatherStationProDuo
{
    class Program
    {
        static void Main(string[] args)
        {
			InWeatherData weatherDataIn = new InWeatherData();
			OutWeatherData weatherDataOut = new OutWeatherData();

			CDisplay display = new CDisplay(weatherDataIn, weatherDataOut);
			CStatsDisplay statsDisplay = new CStatsDisplay(weatherDataIn, weatherDataOut);

			weatherDataIn.RegisterObserver(statsDisplay, 0);
			weatherDataOut.RegisterObserver(statsDisplay, 0);
			weatherDataIn.RegisterObserver(display, 1);
			weatherDataOut.RegisterObserver(display, 1);

			weatherDataIn.SetMeasurements(10, 0.5, 760);
			weatherDataOut.SetMeasurements(-20, 0.1, 760, 10, 180);

			weatherDataIn.RemoveObserver(display);

			weatherDataIn.SetMeasurements(10, 0.8, 754);
			weatherDataOut.SetMeasurements(-10, 0.8, 754, 4, 90);
		}
    }
}
