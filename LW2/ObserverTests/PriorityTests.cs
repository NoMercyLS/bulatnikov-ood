using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.WeatherData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObserverTests
{
    [TestClass]
    public class PriorityTests
    {
        [TestMethod]
        public void ObserversMustBeNotifietByPriority_ShouldReturnPriorityDESC()
        {
            string expected = "3;2;1;0;";
            var weatherData = new CWeatherData();
            var disp1 = new ObserverTestClass(0);
            var disp2 = new ObserverTestClass(1);
            var disp3 = new ObserverTestClass(2);
            var disp4 = new ObserverTestClass(3);

            weatherData.RegisterObserver(disp1, 0);
            weatherData.RegisterObserver(disp2, 1);
            weatherData.RegisterObserver(disp3, 2);
            weatherData.RegisterObserver(disp4, 3);

            var output = new StringWriter();
            Console.SetOut(output);
            Console.SetError(output);
            weatherData.SetMeasurements(1, 0.1, 500);

            Assert.AreEqual(expected, output.ToString());
        }
    }
}
