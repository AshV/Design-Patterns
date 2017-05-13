using System;
using static System.Console;

namespace E_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation ws = new WeatherStation();
            ws.subscribe(new CurrentConditionsDisplay());
            ws.subscribe(new StatisticsDisplay());
            ws.subscribe(new ForecastDisplay());

            string c = "C";
            while (c.Equals("C"))
            {
                WriteLine("Enter the sensor values:");
                float temp = Convert.ToSingle(ReadLine());
                float pressure = Convert.ToSingle(ReadLine());
                float humidity = Convert.ToSingle(ReadLine());
                ws.notify(temp, pressure, humidity);
                c = ReadLine();
            }
        }
    }
}