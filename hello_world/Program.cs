bool isRaining = true;
bool hasUmbrella = false;

if ((isRaining && hasUmbrella) || !isRaining)
{
    Console.WriteLine("I'll be fine");
}
else if (isRaining && !hasUmbrella)
{
    Console.WriteLine("I'll get wet");
}