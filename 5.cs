using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _555
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string name;
                int age;
                float height;

               
                while (true)
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(name))
                        break;
                    else
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                }

               
                while (true)
                {
                    Console.Write("Enter your age (integer): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out age))
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }

                
                while (true)
                {
                    Console.Write("Enter your height (e.g., 5.9): ");
                    string input = Console.ReadLine();

                    if (float.TryParse(input, out height))
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid decimal number for height.");
                }

                Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");
            
        }

    }
}
