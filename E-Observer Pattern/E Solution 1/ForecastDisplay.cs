namespace E_Solution_1
{
    public class ForecastDisplay
    {
        private Weather weather_forecast;

        public ForecastDisplay()
        {
            weather_forecast = new Weather();
        }

        public void update(Weather weather)
        {
            weather_forecast.setTemp(weather.getTemp() * 2 + 3);
            weather_forecast.setPressure(weather.getPressure() * 10 - 5);
            weather_forecast.setHumidity(weather.getHumidity() + 4);
            System.Console.WriteLine("Forecasted Temperature:" + weather.getTemp());
            System.Console.WriteLine("Forecasted Pressure:" + weather.getPressure());
            System.Console.WriteLine("Forecasted Humidity:" + weather.getHumidity());
        }
    }
}