using System;
using static System.Console;

class JsonParser
{
    private string Source { get; set; }

    private string JsonData { get; set; }

    public JsonParser(string source, string jsonData)
    {
        Source = source;
        JsonData = jsonData;
    }

    private object ParseSensorData()
    {
        WriteLine("Parsing Sensor Json Data");
        // Logic optimized for parsing Sensor Data
        return new { ParsedData = JsonData };
    }

    private object ParseBlogData()
    {
        WriteLine("Parsing Blog Json Data");
        // Logic optimized for parsing Blog Data
        return new { ParsedData = JsonData };
    }


    public object Parse()
    {
        switch (Source)
        {
            case "sensor":
                return ParseSensorData();
            case "blog":
                return ParseBlogData();
            default:
                throw new Exception("parser not available for given type.");
        }
    }
}