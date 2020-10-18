using System;
using WeatherStationPro.WeatherData;

namespace WeatherStationPro
{
    class Program
    {
        static void Main(string[] args)
        {
            CWeatherData wd = new CWeatherData();
            CDisplay display = new CDisplay();
            wd.RegisterObserver(display, 1);


            CStatsDisplay statsDisplay = new CStatsDisplay();
            wd.RegisterObserver(statsDisplay, 0);

            wd.SetMeasurements(10, 0.5, 755, 5, 180);
            wd.SetMeasurements(0, 0.2, 765, 15, 90);

            wd.RemoveObserver(display);

            wd.SetMeasurements(10, 0.5, 760, 5, 270);
            wd.SetMeasurements(-10, 0.8, 760, 15, 180);
        }
    }
}
