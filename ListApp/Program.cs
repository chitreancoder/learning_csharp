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
/* 
List<int> nums = new List<int> { 1, 23, 55, 20, 10, 40, 50 };

nums.Sort();

Console.WriteLine("Sorted numbers: ");
foreach (int num in nums)
{
    Console.Write(num + " ");
}

Console.WriteLine();

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
} */

using ListApp;



List<Product> products = new List<Product> {
    new Product{Name = "Berries", Price = 2.99},
    new Product{Name = "Apples", Price = 1.99},
    new Product{Name = "Bananas", Price = 0.99}
};

foreach (Product product in products)
{
    Console.WriteLine(product.Name + " " + product.Price);
}

List<Product> cheapProducts = products.FindAll(product => product.Price < 2.00);

Console.WriteLine("Cheap products: ");
foreach (Product product in cheapProducts)
{
    Console.WriteLine(product.Name + " " + product.Price);
}

Console.WriteLine("Expensive products: ");

List<Product> expensiveProducts = products.Where(product => product.Price > 2.00).ToList();

foreach (Product product in expensiveProducts)
{
    Console.WriteLine(product.Name + " " + product.Price);
}


int? myAge = null;

Console.WriteLine(myAge);

if (myAge.HasValue)
{
    Console.WriteLine(myAge.Value);
}
else
{
    Console.WriteLine("My age is not set");
}

myAge = 25;

Console.WriteLine(myAge);

if (myAge.HasValue)
{
    Console.WriteLine(myAge.Value);
}
else
{
    Console.WriteLine("My age is not set");
}