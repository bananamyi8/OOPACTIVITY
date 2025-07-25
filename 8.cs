using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (digits only): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int result = number + 10;
                Console.WriteLine("Result after adding 10: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter digits only.");
            }
        }
    }

}