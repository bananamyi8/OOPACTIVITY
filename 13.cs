using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || !IsAllLetters(name))
            {
                Console.WriteLine("Invalid input. Please enter alphabetic characters only.");
            }
            else
            {
                string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                Console.WriteLine("Formatted name: " + formattedName);
            }
        }
        static bool IsAllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    
    }

}