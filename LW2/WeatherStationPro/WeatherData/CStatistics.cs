using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.WeatherData
{
    public class CStatistics
    {
        private CStatisticalData _temperatureData = new CStatisticalData();
        private CStatisticalData _humidityData = new CStatisticalData();
        private CStatisticalData _pressureData = new CStatisticalData();
        private CDirectionStatisticalData _directionData = new CDirectionStatisticalData();
        private CStatisticalData _speedData = new CStatisticalData();
        private string GetStatisticalData(CStatisticalData data)
        {
            return $"\n\t\tMax: {data.GetMaxValue()}\n\t\tMin: {data.GetMinValue()}\n\t\tAvg: {data.GetAvgValue()}\n";
        }
        private string GetDirectionStatisticalData(CDirectionStatisticalData data)
        {
            return $"\tAverage wind direction: {data.GetAverageDirection()}°\n";
        }
        public void PrintStats(SWeatherInfo data)
        {
            _temperatureData.UpdateStatisticalData(data.temperature);
            _humidityData.UpdateStatisticalData(data.temperature);
            _pressureData.UpdateStatisticalData(data.temperature);
            _directionData.UpdateWindData(data.wind.direction);
            _speedData.UpdateStatisticalData(data.wind.speed);

            Console.WriteLine("Statistical data:");
            Console.WriteLine($"\tTemperature: {GetStatisticalData(_temperatureData)}");
            Console.WriteLine($"\tHumidity: {GetStatisticalData(_humidityData)}");
            Console.WriteLine($"\tPressure: {GetStatisticalData(_pressureData)}");
            Console.WriteLine($"{GetDirectionStatisticalData(_directionData)}");
            Console.WriteLine($"\tWind speed: {GetStatisticalData(_speedData)}");
        }
    }
}
