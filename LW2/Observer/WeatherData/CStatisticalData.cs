using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.WeatherData
{
    public class CStatisticalData
    {
        private double _minMeasurement = double.PositiveInfinity;
        private double _maxMeasurement = double.NegativeInfinity;
        private double _accMeasurements = 0;
        private uint _countMeasurements = 0;
        public void UpdateStatisticalData(double value)
        {
            if (_minMeasurement > value)
            {
                _minMeasurement = value;
            }
            if (_maxMeasurement < value)
            {
                _maxMeasurement = value;
            }
            _accMeasurements += value;
            ++_countMeasurements;
        }
<<<<<<< HEAD
        public double GetMinValue()
        {
            return _minMeasurement;
        }
        public double GetMaxValue()
        {
            return _maxMeasurement;
        }
        public double GetAvgValue()
        {
            return _accMeasurements / _countMeasurements;
=======
        public string GetStatisticalData()
        {
            return $"\nMax: {Math.Round(_maxMeasurement, 4)}\nMin: {Math.Round(_minMeasurement, 4)}\nAvg: {Math.Round(_accMeasurements / _countMeasurements, 2)}\n";
>>>>>>> 04054be3bc751a429a71c552fba36cafad3cc8bd
        }
    }
}
