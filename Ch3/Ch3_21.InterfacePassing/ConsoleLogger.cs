namespace Ch3_21.InterfacePassing;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.Write(message +" ");
    }
}