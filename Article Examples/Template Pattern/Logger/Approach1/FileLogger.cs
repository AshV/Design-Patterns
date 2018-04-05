using static System.Console;

public class FileLogger
{
    public void Log(string message) {
        OpenFile();
        WriteLogMessage(message);
        CloseFile();
    }

    private void OpenFile() {
        WriteLine("Opening File.");
    }

    private void WriteLogMessage(string message) {
        WriteLine("Appending Log message to file : " + message);
    }

    private void CloseFile() {
        WriteLine("Close File.");
    }
}