Console.WriteLine("Enter the number of days to simulate weather:");
int days =  int.Parse(Console.ReadLine());

int[] temperature = new int[days];
string[] conditions = {"Sunny", "Cloudy", "Rainy", "Snowy"};
string[] weatherConditions = new string[days];

Random rand = new Random();

for (int i = 0; i < days; i++)
{
    temperature[i] = rand.Next(-10, 40);
    weatherConditions[i] = conditions[rand.Next(conditions.Length)];
    
    Console.WriteLine("On day " + i + " the temperature is " + temperature[i] + "°C" + " and it´s " + weatherConditions[i]);
}

Console.WriteLine($"The average temperature was: {CalculateAverage(temperature)}°C");
Console.WriteLine($"The min temperature was: {temperature.Min()}°C");
Console.WriteLine($"The max temperature was: {temperature.Max()}°C");
Console.WriteLine($"The most common condition was: {getMostCommonConditions(weatherConditions)}");



double CalculateAverage(int[] temperature)
{
    double sum = 0;

    foreach (int temp  in temperature)
    {
        sum += temp;
    }

    return sum / temperature.Length;
}

string getMostCommonConditions(string[] conditions)
{
    int count = 0;
    string mostCommon = conditions[0];

    for (int c = 0; c < conditions.Length; c++)
    {
        int tempCount = 0;

        for (int i = 0; i < conditions.Length; i++)
        {
            if (conditions[c] == conditions[i])
            {
                tempCount++;
            }
        }

        if (tempCount > count)
        {
            count = tempCount;
            mostCommon = conditions[c];
        }
    }
    return mostCommon;
}