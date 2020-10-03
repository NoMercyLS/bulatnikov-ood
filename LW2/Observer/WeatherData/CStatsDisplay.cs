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
            Console.WriteLine("Statistical data:");
            Console.WriteLine($"Temperature: {_temperatureData.GetStatisticalData(data.temperature)}");
            Console.WriteLine($"Humidity: {_humidityData.GetStatisticalData(data.humidity)}");
            Console.WriteLine($"Pressure: {_pressureData.GetStatisticalData(data.pressure)}");
        }
    }
}
