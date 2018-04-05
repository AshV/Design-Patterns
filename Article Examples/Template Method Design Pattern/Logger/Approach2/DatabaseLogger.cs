using static System.Console;

public class DatabaseLogger : Logger
{
    public void Log(string message) {
        ConnectToDatabase();
        LogMessage(message);
        CloseDbConnection();
    }

    private void ConnectToDatabase() {
        WriteLine("Connecting to Database.");
    }

    private void CloseDbConnection() {
        WriteLine("Closing DB connection.");
    }
}