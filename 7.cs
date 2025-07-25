using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter another number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /: ");
            string opera = Console.ReadLine();

            float result;

            if (opera == "+")
            {
                result = num1 + num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "-")
            {
                result = num1 - num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "*")
            {
                result = num1 * num2;
                Console.WriteLine("The result is: " + result);
            }
            else if (opera == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("The result is: " + result);
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid operator.");
            }
        }
    }
}
