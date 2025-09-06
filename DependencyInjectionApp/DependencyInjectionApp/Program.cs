
MultiFuncPinter printer = new MultiFuncPinter();
printer.Print();
printer.Scan();

public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public class MultiFuncPinter : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("IScannable.Print()");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}