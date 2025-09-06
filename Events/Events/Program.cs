TemperatureMonitor monitor = new TemperatureMonitor();
TemperatureAlert alert = new TemperatureAlert();
monitor.OnTemperatureChange += alert.OnTemperatureChange;

monitor.Temperature = 20;

while (true)
{
    Console.WriteLine("Please enter the temperature: ", ConsoleColor.Yellow);
    monitor.Temperature = int.Parse(Console.ReadLine());
}


public delegate void TemperatureChangeHandler(string msg);

public class TemperatureMonitor
{
    public event TemperatureChangeHandler OnTemperatureChange;

    private int _temperature;

    public int Temperature
    {
        get { return _temperature; }
        set
        {
            _temperature = value;
            if (_temperature > 30)
            {
                // Raise event
                RaiseTemperatureChangedEvent("Temperature is too high.");
            }
        }
    }

    protected virtual void RaiseTemperatureChangedEvent(string msg)
    {
        OnTemperatureChange?.Invoke(msg);
    }
}

public class TemperatureAlert
{
    public void OnTemperatureChange(string msg)
    {
        Console.WriteLine("Alert: " + msg);
    }
}