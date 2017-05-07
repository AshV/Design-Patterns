using System;
using static System.Console;

namespace E_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation ws = new WeatherStation();

            string X = "";
            do
            {
                WriteLine("Enter the sensor values:");
                float temp = Convert.ToSingle(ReadLine());
                float pressure = Convert.ToSingle(ReadLine());
                float humidity = Convert.ToSingle(ReadLine());
                ws.notify(temp, pressure, humidity);
                WriteLine("Enter to Continue, X to Exit.");
                X = ReadLine();
            } while (!X.Equals("X"));
        }
    }
}