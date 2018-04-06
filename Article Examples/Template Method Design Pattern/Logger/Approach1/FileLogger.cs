using static System.Console;

public class FileLogger
{
    public void Log(object message)
    {
        string messageToLog = SerializeMessage(message);
        OpenFile();
        WriteLogMessage(messageToLog);
        CloseFile();
    }

    private void OpenFile()
    {
        WriteLine("Opening File.");
    }

    private string SerializeMessage(object message)
    {
        WriteLine("Serializing message");
        return message.ToString();
    }

    private void WriteLogMessage(string message)
    {
        WriteLine("Appending Log message to file : " + message);
    }

    private void CloseFile()
    {
        WriteLine("Close File.");
    }
}