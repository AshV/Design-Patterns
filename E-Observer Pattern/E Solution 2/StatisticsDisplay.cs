using System;
using static System.Console;

namespace E_Solution_2
{
    public class StatisticsDisplay : IDisplay
    {
        private float minTemp;
        private float maxTemp;
        private float minPressure;
        private float maxPressure;

        public StatisticsDisplay()
        {
            minTemp = float.MaxValue;
            maxTemp = float.MinValue;
        }

        public void update(Weather weather)
        {
            minTemp = Math.Min(minTemp, weather.getTemp());
            maxTemp = Math.Max(maxTemp, weather.getTemp());
            minPressure = Math.Min(minPressure, weather.getPressure());
            maxPressure = Math.Max(maxPressure, weather.getPressure());
            WriteLine("MinTemp:" + minTemp + ",MaxTemp:" + maxTemp);
            WriteLine("MinPresure:" + minPressure + ",MaxPressure:" + maxPressure);
        }
    }
}