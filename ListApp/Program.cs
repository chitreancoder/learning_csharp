/* List<string> colors = new List<string>{"Red", "Blue", "Green", "Blue"};

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
 */

List<int> nums = new List<int> { 1, 23, 55, 20, 10, 40, 50 };

nums.Sort();

Console.WriteLine("Sorted numbers: ");
foreach (int num in nums)
{
    Console.Write(num + " ");
}

Console.WriteLine();

// The lambda expression is a way to filter the list and return only the even numbers.
// The find all requires a predicate function.
// The predicate function is a function that takes a parameter and returns a boolean.
// And reference to the lambda expression is a function that takes a parameter and returns a boolean.
List<int> evenNums = nums.FindAll(num => num % 2 == 0);

Console.WriteLine("Even numbers: ");
foreach (int num in evenNums)
{
    Console.Write(num + " ");
}

bool oddNums = nums.Any(num => num % 2 != 0);

Console.WriteLine("Odd numbers: ");
if (oddNums)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}