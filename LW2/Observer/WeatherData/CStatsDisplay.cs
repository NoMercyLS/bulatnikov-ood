using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.WeatherData
{
    public class CStatsDisplay : Observer.IObserver<SWeatherInfo>
    {
        private CStatisticalData _temperatureData = new CStatisticalData();
        private CStatisticalData _humidityData = new CStatisticalData();
        private CStatisticalData _pressureData = new CStatisticalData();
        private string GetStatisticalData(CStatisticalData data)
        {
            return $"Max: {data.GetMaxValue()}\nMin: {data.GetMinValue()}\nAvg: {data.GetAvgValue()}";
        }
        public void Update(SWeatherInfo data)
        {
            _temperatureData.UpdateStatisticalData(data.temperature);
            _humidityData.UpdateStatisticalData(data.humidity);
            _pressureData.UpdateStatisticalData(data.pressure);

            Console.WriteLine("Statistical data:");
            Console.WriteLine($"Temperature: {GetStatisticalData(_temperatureData)}");
            Console.WriteLine($"Humidity: {GetStatisticalData(_humidityData)}");
            Console.WriteLine($"Pressure: {GetStatisticalData(_pressureData)}");
        }
    }
}
