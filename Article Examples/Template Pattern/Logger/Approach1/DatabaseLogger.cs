using static System.Console;

public class DatabaseLogger
{
    public void Log(string message) {
        ConnectToDatabase();
        InsertLogMessageToTable(message);
        CloseDbConnection();
    }

    private void ConnectToDatabase() {
        WriteLine("Connecting to Database.");
    }

    private void InsertLogMessageToTable(string message) {
        WriteLine("Inserting Log Message to DB table." + message);
    }

    private void CloseDbConnection() {
        WriteLine("Closing DB connection.");
    }
}