using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _177
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-10): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 1 && number <= 10)
            {
                Console.WriteLine($"\nMultiplication Table of {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 10.");
            }
        }
    }
}
