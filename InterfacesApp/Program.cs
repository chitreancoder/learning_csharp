
ILogger fileLogger = new FileLogger();
Application app = new Application(fileLogger);
app.Log();


ILogger dbLogger = new DatabaseLogger();
app = new Application(dbLogger);
app.Log();


public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to DB: " + message);
    }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void Log()
    {
        _logger.Log("Do the work");
        _logger.Log("Work done");
    }
}