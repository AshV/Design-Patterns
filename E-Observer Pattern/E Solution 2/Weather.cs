namespace E_Solution_2
{
    public class Weather
    {
        private float temp;
        private float pressure;
        private float humidity;

        public Weather()
        {
        }

        public Weather(float temp, float pressure, float humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;
        }

        public float getTemp()
        {
            return temp;
        }

        public void setTemp(float temp)
        {
            this.temp = temp;
        }

        public float getPressure()
        {
            return pressure;
        }

        public void setPressure(float pressure)
        {
            this.pressure = pressure;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public void setHumidity(float humidity)
        {
            this.humidity = humidity;
        }
    }
}