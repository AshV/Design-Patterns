using System;

namespace E_Solution_1
{
public    class StatisticsDisplay
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
            Console.WriteLine("MinTemp:" + minTemp + ",MaxTemp:" + maxTemp);
            Console.WriteLine("MinPresure:" + minPressure + ",MaxPressure:" + maxPressure);
        }
    }
}