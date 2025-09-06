
EventPublisher pub = new EventPublisher();
EventSubscriber sub = new EventSubscriber();
pub.OnNotify += sub.OnEventRaised;
pub.RaiseEvent("Testing event");

public delegate void Notify(string msg);

public class EventPublisher
{
    public event Notify OnNotify;

    public void RaiseEvent(string msg)
    {
        OnNotify?.Invoke(msg); // Invokes event only if there are susbscribers.
        
    }
}

public class EventSubscriber
{
    public void OnEventRaised(string msg)
    {
        Console.WriteLine("Event received: " + msg);
    }
}