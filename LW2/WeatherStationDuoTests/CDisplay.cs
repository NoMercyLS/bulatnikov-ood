using System;
using System.Collections.Generic;
using System.Text;
using WeatherStationDuo.WeatherData;

namespace WeatherStationDuoTests
{
    class CDisplay : WeatherStationDuo.Observer.IObserver<SWeatherInfo>
    {
        private readonly CWeatherData _insideData;
        private readonly CWeatherData _outsideData;

        public CDisplay(CWeatherData insideData, CWeatherData outsideData)
        {
            _insideData = insideData;
            _outsideData = outsideData;
        }

        public void Update(SWeatherInfo data, WeatherStationDuo.Observer.IObservable<SWeatherInfo> observable)
        {
            if (_insideData == observable)
            {
                Console.Write("Inside;");
            }
            if (_outsideData == observable)
            {
                Console.Write("Outside;");
            }
        }
    }
}
