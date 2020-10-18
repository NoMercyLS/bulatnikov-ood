using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationPro.WeatherData
{
    public class CDirectionStatisticalData
    {
        private double _sinAcc = 0;
        private double _cosAcc = 0;
        private double _countAcc = 0;

        private double ConvertDegreeToRadian(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        private double ConvertRadianToDegree(double angle)
        {
            return (180 / Math.PI) * angle;
        }

        public void UpdateWindData(double angle)
        {
            _sinAcc += Math.Sin(ConvertDegreeToRadian(angle));
            _cosAcc += Math.Cos(ConvertDegreeToRadian(angle));
            ++_countAcc;
        }

        public double GetAverageDirection()
        {
            var avgDirection = (
                ConvertRadianToDegree(
                Math.Atan2(_sinAcc / _countAcc, _cosAcc / _countAcc)) + 360
                ) % 360;
            return avgDirection;
        }
    }
}
