using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationProDuo.WeatherData
{
    public class CStatsDisplay : Observer.IObserver<SWeatherInfo>
    {
        private CStatistics _insideStats = new CStatistics();
        private CStatistics _outsideStats = new CStatistics();

        private readonly InWeatherData _insideData;
        private readonly OutWeatherData _outsideData;
        public CStatsDisplay(InWeatherData insideData, OutWeatherData outsideData)
        {
            _insideData = insideData;
            _outsideData = outsideData;
        }
        public void Update(SWeatherInfo data, Observer.IObservable<SWeatherInfo> observable)
        {
            if (_insideData == observable)
            {
                Console.Write("Inside ");
                _insideStats.PrintStats(data);
            }
            if (_outsideData == observable)
            {
                Console.Write("Outside ");
                _outsideStats.PrintStats(data);
            }
        }
    }
}
