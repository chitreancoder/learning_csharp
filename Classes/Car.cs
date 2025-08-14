namespace DefaultNamespace;

public class Car
{
	// member variable
    private string _model = "";

	// property
	public string Model {get => _model; 
		set{
		if(string.IsNullOrEmpty(value)){
		Console.WriteLine("You entered NOTHING!");
		_model = "DEFAULTVALUE";

}else {
_model=value;
}
}
}
    
	public Car(string model)
    {
        Model = model;
        Console.WriteLine("An object of car has been created and the model is" + Model);
    }
}