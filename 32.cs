using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a capital letter (A-Z): ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input < 'A' || input > 'Z')
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            for (char row = 'A'; row <= input; row++)
            {
                for (char c = 'A'; c <= row; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
