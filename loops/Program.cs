/*
// See https://aka.ms/new-console-template for more information

var rand = new Random();

int numberToGuess = rand.Next(0, 101);
Console.WriteLine("Guess a number between 0 and 101");
int guessedNumber = -1; 
while (guessedNumber != numberToGuess)
{
    guessedNumber = int.Parse(Console.ReadLine());
    if (guessedNumber > numberToGuess)
    {
        Console.WriteLine("Wrong guess, try lower");
    }
    else if (guessedNumber < numberToGuess)
    {
        Console.WriteLine("Wrong guess, try higher");
    }
    else
    {
        Console.WriteLine("Congrats the number was indeed " + guessedNumber);
    }
 
}
*/
/*int sum = 0;
int[] scores = [7,7,8,9,8,10];
System.Console.WriteLine("Hello");
for (int i = 0; i < scores.Length; i++)
{
    System.Console.WriteLine(scores[i]);
    sum += scores[i];
}
double avg = sum / scores.Length;
System.Console.WriteLine("The average is " + avg + " " + sum + " " + scores.Length);*/

int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int rowZero = 0;
int rowOne = 0;
int rowTwo = 0;

for (int i = 0; i < twoDArray.GetLength(0); i++)
{
    
    
    for (int j = 0; j < twoDArray.GetLength(1); j++)
    {
        rowZero += twoDArray[i, 0];
        rowOne += twoDArray[i, 1];
        rowTwo += twoDArray[i, 2];
    } 
    
 
}  

Console.WriteLine(rowZero);
Console.WriteLine(rowOne);
Console.WriteLine(rowTwo);