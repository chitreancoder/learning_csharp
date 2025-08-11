using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();
            
            if(operation == "+"){
                int result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }else if (operation == "-"){
                 int result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }else if (operation == "*"){
                      int result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }else if (operation == "/"){
                if(num2 == 0){
                       Console.WriteLine("Error: Division by zero is not allowed.");
                }else {
                          int result = num1 / num2;
                Console.WriteLine("Result: " + result);
                }
              
            }else {
                   Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            }
            
        }
    }
}
