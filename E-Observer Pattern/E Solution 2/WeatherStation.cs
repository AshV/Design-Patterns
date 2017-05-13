using System.Collections.Generic;

namespace E_Solution_2
{
    public class WeatherStation
    {
        private List<IDisplay> display_units;

        public WeatherStation()
        {
            display_units = new List<IDisplay>();
        }

        public void subscribe(IDisplay display)
        {
            display_units.Add(display);
        }

        public void unsubscribe(IDisplay display)
        {
            display_units.Remove(display);
        }

        public void notify(float temp, float pressure, float humidity)
        {
            Weather weather = new Weather(temp, pressure, humidity);
            foreach (var display in display_units)
                display.update(weather);
        }
    }
}