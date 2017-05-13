using static System.Console;

namespace E_Solution_2
{
    public class ForecastDisplay : IDisplay
    {
        public Weather weather_forecast;

        public ForecastDisplay()
        {
            weather_forecast = new Weather();
        }
        public void update(Weather weather)
        {
            weather_forecast.setTemp(weather.getTemp() * 2 + 3);
            weather_forecast.setPressure(weather.getPressure() * 10 - 5);
            weather_forecast.setHumidity(weather.getHumidity() + 4);
            WriteLine("Forecasted Temperature:" + weather.getTemp());
            WriteLine("Forecasted Pressure:" + weather.getPressure());
            WriteLine("Forecasted Humidity:" + weather.getHumidity());
        }
    }
}