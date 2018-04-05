using static System.Console;

public class EmailLogger
{
    public void Log(string message) {
        ConnectToMailServer();
        SendLogToEmail(message);
    }

    private void ConnectToMailServer() {
        WriteLine("Connecting to mail server and logging in");
    }

    private void SendLogToEmail(string message) {
        WriteLine("Sending Email with Log Message." + message);
    }
}