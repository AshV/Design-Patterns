using static System.Console;

public class DatabaseLogger : Logger
{
    protected override void OpenConnection() {
        WriteLine("Connecting to Database.");
    }

    protected override void CloseConnection() {
        WriteLine("Closing DB connection.");
    }
}