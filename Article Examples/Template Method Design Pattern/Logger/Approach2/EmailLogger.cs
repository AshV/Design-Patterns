using static System.Console;

public class EmailLogger : Logger
{
    public void Log(string message) {
        ConnectToMailServer();
        LogMessage(message);
    }

    private void ConnectToMailServer() {
        WriteLine("Connecting to mail server and logging in");
    }
}