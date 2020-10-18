using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.WeatherData
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
        }
    }
}