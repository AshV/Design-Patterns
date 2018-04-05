using static System.Console;

public class FileLogger : Logger
{
    public void Log(string message) {
        OpenFile();
        LogMessage(message);
        CloseFile();
    }

    private void OpenFile() {
        WriteLine("Opening File.");
    }

    private void CloseFile() {
        WriteLine("Close File.");
    }
}