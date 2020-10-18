using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.WeatherData
{
    public class CStatsDisplay : Observer.IObserver<SWeatherInfo>
    {
        private CStatistics statistics = new CStatistics();

        public void Update(SWeatherInfo data)
        {
            statistics.PrintStats(data);
        }
    }
}
