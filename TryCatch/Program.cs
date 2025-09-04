

try
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    Console.WriteLine(numbers[10]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed");
}

public void HandleMultipleExceptions(string x, int y)
{
    int[] numbers = { 1, 2, 3 };

    try
    {
        int.Parse(x);
        int num = numbers[y];
        Console.WriteLine(num);
    }
    catch (FormatException fe)
    {
        Console.WriteLine("Invalid format.");
    }
    catch (IndexOutOfRangeException ide)
    {
        Console.WriteLine("Index out of range.");
    }
}