using static System.Console;

public class FileLogger : AbstractLogger
{
    public void Log(string message) {
        OpenFile();
        CloseFile();
    }

    private void OpenFile() {
        WriteLine("Opening File.");
    }

    private void CloseFile() {
        WriteLine("Close File.");
    }
}