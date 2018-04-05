using static System.Console;

public class FileLogger : Logger
{
    protected override void OpenConnection() {
        WriteLine("Opening File.");
    }

    protected override void CloseConnection() {
        WriteLine("Close File.");
    }
}