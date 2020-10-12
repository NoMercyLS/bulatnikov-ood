using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.WeatherData
{
    public class CStatsDisplay : Observer.IObserver<SWeatherInfo>
    {
        private CStatisticalData _temperatureData = new CStatisticalData();
        private CStatisticalData _humidityData = new CStatisticalData();
        private CStatisticalData _pressureData = new CStatisticalData();
        public void Update(SWeatherInfo data)
        {
            _temperatureData.UpdateStatisticalData(data.temperature);
            _humidityData.UpdateStatisticalData(data.humidity);
            _pressureData.UpdateStatisticalData(data.pressure);
            Console.WriteLine("Statistical data:");
            Console.WriteLine($"Temperature: {_temperatureData.GetStatisticalData()}");
            Console.WriteLine($"Humidity: {_humidityData.GetStatisticalData()}");
            Console.WriteLine($"Pressure: {_pressureData.GetStatisticalData()}");
        }
    }
}
