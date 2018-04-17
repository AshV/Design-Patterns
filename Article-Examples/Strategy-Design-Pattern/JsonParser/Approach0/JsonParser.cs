using static System.Console;

class JsonParser {
    public object Parse(string source, string jsonData) {
        WriteLine("Parsing Json Data");
        // Parsing Logic
        return new { ParsedData = jsonData };
    }
}