Hammer hammer = new Hammer();
Saw saw = new Saw();
Builder builder = new Builder(hammer);
builder.Saw = saw;
ScrewDriver screwDriver = new ScrewDriver();
builder.SetScrewDriver(screwDriver);
builder.Build();


public interface ITools
{
    void SetScrewDriver(ScrewDriver screwDriver);
}


public class ScrewDriver
{
    public void Use()
    {
        Console.WriteLine("Screwing");
    }
}

public class Hammer
{
    public void Use()
    {
        Console.WriteLine(("Hammering"));
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing");
    }
}

public class Builder : ITools
{
    private ScrewDriver _screwDriver;
    private Hammer _hammer;
    public Saw Saw { get; set; }

    public void SetScrewDriver(ScrewDriver screwDriver)
    {
        _screwDriver = screwDriver;
    }

    public Builder(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void Build()
    {
        _hammer.Use();
        Saw.Use();
        _screwDriver.Use();
    }
}