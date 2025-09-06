TemperatureMonitor monitor = new TemperatureMonitor();
TemperatureAlert alert = new TemperatureAlert();
monitor.TemperatureChanged += alert.OnTemperatureChange;

monitor.Temperature = 20;

while (true)
{
    Console.WriteLine("Please enter the temperature: ", ConsoleColor.Yellow);
    monitor.Temperature = int.Parse(Console.ReadLine());
}


public delegate void TemperatureChangeHandler(string msg);


public class TemperatureChangeEventArgs: EventArgs {
    public int Temperature { get;}

    public TemperatureChangeEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}
public class TemperatureMonitor
{
    
    public event TemperatureChangeHandler OnTemperatureChange;
    
    public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;

    private int _temperature;

    public int Temperature
    {
        get { return _temperature; }
        set
        {
        
            if (_temperature != value)
            {
                _temperature = value;
                // Raise event
                OnTemperatureChanged(new TemperatureChangeEventArgs(value));2
                    
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

public class TemperatureAlert
{
    public void OnTemperatureChange(object sender, TemperatureChangeEventArgs e)
    {
        Console.WriteLine($"Alert: temperature: {e.Temperature}, sender is: {sender}");
    }
}