using static System.Console;

public abstract class Logger
{
    protected void LogMessage(string message) {
        WriteLine(message);
    }
}
// Assuming all steps in Logger classes are independent of each other, so moving LogMessage() to parent class