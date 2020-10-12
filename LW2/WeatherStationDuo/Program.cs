using System;
using WeatherStationDuo.WeatherData;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            CWeatherData inData = new CWeatherData();
            CWeatherData outData = new CWeatherData();

            CDisplay display = new CDisplay(inData, outData);
            inData.RegisterObserver(display, 10);
            outData.RegisterObserver(display, 10);

            CStatsDisplay stats = new CStatsDisplay(inData, outData);
            inData.RegisterObserver(stats, 9);
            outData.RegisterObserver(stats, 8);

            CStatsDisplay stats2 = new CStatsDisplay(inData, outData);
            inData.RegisterObserver(stats2, 0);
            outData.RegisterObserver(stats2, 0);

            inData.SetMeasurements(5, 0.5, 755);
            outData.SetMeasurements(8, 0.3, 760);
            outData.RemoveObserver(stats);

            inData.SetMeasurements(0, 0.5, 755);
            outData.SetMeasurements(-8, 0.3, 760);
        }
    }
}
