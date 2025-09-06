
int[] intArray = new int[] { 1, 2, 3, 4, 5 };
PrintArray(intArray);
PrintArray(new [] {"Helo", "XX"});

void PrintArray<T>(T[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}


















Notify notifyDelegate = ShowMessage;

notifyDelegate("Ciao");



static void ShowMessage(string message)
{
    Console.WriteLine(message);
}


public delegate void Notify(string message);

