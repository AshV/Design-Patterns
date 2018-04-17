using static System.Console;

class JsonParser {
    private string Source { get; set; }

    private string JsonData { get; set; }

    public JsonParser(string source, string jsonData) {
        Source = source;
        JsonData = jsonData;
    }

    public object Parse() {
        WriteLine("Parsing Json Data");
        // Parsing Logic
        return new { ParsedData = JsonData };
    }
}