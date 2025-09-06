Notify notifyDelegate = ShowMessage;

notifyDelegate("Ciao");



static void ShowMessage(string message)
{
    Console.WriteLine(message);
}


public delegate void Notify(string message);

