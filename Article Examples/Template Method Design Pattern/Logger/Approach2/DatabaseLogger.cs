using static System.Console;

public class DatabaseLogger : AbstractLogger
{
    public void Log(string message) {
        ConnectToDatabase();
        CloseDbConnection();
    }

    private void ConnectToDatabase() {
        WriteLine("Connecting to Database.");
    }

    private void CloseDbConnection() {
        WriteLine("Closing DB connection.");
    }
}