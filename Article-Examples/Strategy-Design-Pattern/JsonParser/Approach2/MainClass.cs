class MainClass
{
    static void Main(string[] args)
    {
        JsonParser parsedData = new SensorDataParser("{ 'temp' : '38' }");
        parsedData.Parse();
    }
}