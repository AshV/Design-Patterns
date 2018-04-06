using static System.Console;

public class EmailLogger : AbstractLogger
{
    public void Log(string message) {
        ConnectToMailServer();
    }

    private void ConnectToMailServer() {
        WriteLine("Connecting to mail server and logging in");
    }
}