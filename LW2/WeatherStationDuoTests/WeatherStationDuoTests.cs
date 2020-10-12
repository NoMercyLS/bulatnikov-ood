using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using WeatherStationDuo.WeatherData;

namespace WeatherStationDuoTests
{
    [TestClass]
    public class WeatherStationDuoTest
    {
        [TestMethod]
        public void Notifying_NowWithStationPlacement()
        {
            var insideData = new CWeatherData();
            var outsideData = new CWeatherData();
            var display = new CDisplay(insideData, outsideData);
            insideData.RegisterObserver(display, 1);
            outsideData.RegisterObserver(display, 1);
            var sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetError(sw);
            insideData.SetMeasurements(1, 1, 1);
            outsideData.SetMeasurements(2, 2, 2);
            string result = sw.ToString();
            string expected = "Inside;Outside;";
            Assert.AreEqual(expected, result);
        }
    }
}
