namespace E_Solution_1
{
 public    class WeatherStation
    {
        private CurrentCondtionsDisplay cDisplay;
        private StatisticsDisplay sDisplay;
        private ForecastDisplay fDisplay;

        public WeatherStation()
        {
            cDisplay = new CurrentCondtionsDisplay();
            sDisplay = new StatisticsDisplay();
            fDisplay = new ForecastDisplay();
        }

        public void notify(float temp, float pressure, float humidity)
        {
            Weather weather = new Weather(temp, pressure, humidity);
            cDisplay.update(weather);
            sDisplay.update(weather);
            fDisplay.update(weather);
        }
    }
}