class Program {
    static void Main(string[] args) {
        var parsedData = new JsonParser(
            "sensor",
            "{ 'temp' : '38' }")
            .Parse();
    }
}