namespace DefaultNamespace;

public class Car
{
    private string _model = "";
    public Car(string model)
    {
        _model = model;
        Console.WriteLine("An object of car has been created and the model is" + model);
    }
}