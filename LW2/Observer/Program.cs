using Observer.WeatherData;
using System;
using System.Threading;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            CWeatherData data = new CWeatherData();
            CDisplay display = new CDisplay();
            CStatsDisplay statsDisplay = new CStatsDisplay();

            data.RegisterObserver(display, 100);
            data.RegisterObserver(statsDisplay, 200);

            data.SetMeasurements(8.52, 0.88, 744);
            Thread.Sleep(2000);
            data.SetMeasurements(12.2, 0.65, 768);
            Thread.Sleep(2000);
            data.SetMeasurements(12.2, 0.65, 768);
            Thread.Sleep(2000);
            data.SetMeasurements(12.3, 0.65, 768);
            Thread.Sleep(2000);
            data.SetMeasurements(12.2, 0.76, 754);
            Thread.Sleep(2000);
            data.RemoveObserver(display);
            data.SetMeasurements(8.52, 0.88, 744);
            Thread.Sleep(2000);
            data.SetMeasurements(12.2, 0.65, 768);
            Thread.Sleep(2000);
        }
    }
}
