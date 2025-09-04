Dictionary<int, string> dictionary = new Dictionary<int, string>();

dictionary.Add(1, "One");
dictionary.Add(2, "Two");
dictionary.Add(3, "Three");

string firstValue = dictionary[1];
Console.WriteLine(firstValue);

dictionary[1] = "Seven";

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

if(dictionary.ContainsKey(1))
{
    Console.WriteLine("Key 1 exists");
}
else
{
    Console.WriteLine("Key 1 does not exist");
}

if(dictionary.ContainsValue("Seven"))

dictionary.Remove(1);

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}

bool isAdded = dictionary.TryAdd(1, "Eight");
Console.WriteLine(isAdded);