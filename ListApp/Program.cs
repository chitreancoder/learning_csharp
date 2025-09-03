List<string> colors = new List<string>{"Red", "Blue", "Green", "Blue"};

/*colors.Add("Red");
colors.Add("Blue");
colors.Add("Green");
colors.Add("Blue");*/

colors.Add("Yellow");

bool blueRemoved = colors.Remove("Blue");
while (blueRemoved)
{
    blueRemoved = colors.Remove("Blue");
}
Console.WriteLine("Blue removed");

Console.WriteLine("Colors: ");

foreach (string color in colors)
{
    Console.WriteLine(color);
}
