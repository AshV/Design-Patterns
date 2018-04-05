using static System.Console;

public class EmailLogger : Logger
{
    protected override void CloseConnection() {
        WriteLine("Dummy Close");
    }

    protected override void OpenConnection() {
        WriteLine("Connecting to mail server and logging in");
    }
}