using static System.Console;

namespace E_Solution_1
{
    public class CurrentCondtionsDisplay
    {
        public Weather weather;

        public void update(Weather weather)
        {
            this.weather = weather;
            WriteLine("Temperature:" + weather.getTemp());
            WriteLine("Pressure:" + weather.getPressure());
            WriteLine("Humidity:" + weather.getHumidity());
        }
    }
}