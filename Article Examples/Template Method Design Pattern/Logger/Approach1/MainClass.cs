using static System.Console;

class MainClass
{
    static void Main(string[] args) {
        FileLogger fileLogger = new FileLogger();
        fileLogger.Log("Message to Log.");

        WriteLine();

        EmailLogger emailLogger = new EmailLogger();
        emailLogger.Log("Message to Log.");

        WriteLine();

        DatabaseLogger databaseLogger = new DatabaseLogger();
        databaseLogger.Log("Message to Log.");
    }
}