using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter a position (starting from 0): ");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= word.Length)
            {
                Console.WriteLine("Error: Index is out of range.");
            }
            else
            {
                Console.WriteLine("Character at position " + index + ": " + word[index]);
            }
        }
    }
}
