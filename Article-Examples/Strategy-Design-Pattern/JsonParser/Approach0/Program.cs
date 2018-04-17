class Program {
    static void Main(string[] args) {
        var pasredData = new JsonParser().Parse(
            "sensor",
            "{ 'temp' : '38' }");
    }
}