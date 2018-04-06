using static System.Console;

public class EmailLogger : AbstractLogger
{
    public void Log(object message)
    {
        string messageToLog = SerializeMessage(message);
        ConnectToMailServer();
        SendLogToEmail(messageToLog);
    }

    private void ConnectToMailServer()
    {
        WriteLine("Connecting to mail server and logging in");
    }

    private void SendLogToEmail(string message)
    {
        WriteLine("Sending Email with Log Message : " + message);
    }
}