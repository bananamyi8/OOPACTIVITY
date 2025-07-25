using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            
            do {
                Console.WriteLine($"Guess the secret word:");
                word = Console.ReadLine();

            if (word != "open")
                Console.WriteLine("Try again.");

            } while (word != "open");

            Console.WriteLine("Correct!");

        }
    }
}
