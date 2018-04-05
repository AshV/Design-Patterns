using static System.Console;

public abstract class Logger
{
    protected void LogMessage(string message) {
        WriteLine(message);
    }

    protected abstract void OpenConnection();
    protected abstract void CloseConnection();

    public void Log(string message) {
        OpenConnection();
        LogMessage(message);
        CloseConnection();
    }
}