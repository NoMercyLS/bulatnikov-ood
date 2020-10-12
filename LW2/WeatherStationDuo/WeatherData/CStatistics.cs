﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationDuo.WeatherData
{
    class CStatistics
    {
        private CStatisticalData _temperatureData = new CStatisticalData();
        private CStatisticalData _humidityData = new CStatisticalData();
        private CStatisticalData _pressureData = new CStatisticalData();
        private string GetStatisticalData(CStatisticalData data)
        {
            return $"Max: {data.GetMaxValue()}\nMin: {data.GetMinValue()}\nAvg: {data.GetAvgValue()}";
        }
        public void PrintStats(SWeatherInfo data)
        {
            _temperatureData.UpdateStatisticalData(data.temperature);
            _humidityData.UpdateStatisticalData(data.temperature);
            _pressureData.UpdateStatisticalData(data.temperature);

            Console.WriteLine(" statistical data:");
            Console.WriteLine($"Temperature: {GetStatisticalData(_temperatureData)}");
            Console.WriteLine($"Humidity: {GetStatisticalData(_humidityData)}");
            Console.WriteLine($"Pressure: {GetStatisticalData(_pressureData)}");
        }
    }
}