Point point = new Point(15,32);
point.Display();

Point p2;

p2.X = 14;
p2.Y = 10;
p2.Display();

PointClass pc1 = new PointClass(10, 5);
pc1.Display();
PointClass pc2 = pc1;

pc2.X = 30;
pc2.Display();
pc1.Display();

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X},{Y})");
    }
}

public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }

    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
        
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X},{Y})");
    }
}
