using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.WeatherData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverTests
{
    [TestClass]
    public class RemoveOnUpdateTest
    {
        [TestMethod]
        public void RemoveObserverOnUpdate_ShouldPass()
        {
            CWeatherData weatherData = new CWeatherData();
            UpdateObserverTest obs = new UpdateObserverTest(weatherData);

            weatherData.RegisterObserver(obs, 1);
            weatherData.SetMeasurements(1, 0.1, 500);
        }
    }
}
