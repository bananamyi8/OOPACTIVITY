using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Convert to (upper/lower): ");
            string choice = Console.ReadLine().Trim().ToLower();

            if (choice != "upper" && choice != "lower")
            {
                Console.WriteLine("Invalid choice! Please enter 'upper' or 'lower'.");
                return;
            }

            string result = "";

            foreach (char ch in sentence)
            {
                if (choice == "upper")
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        result += (char)(ch - ('a' - 'A'));
                    }
                    else
                    {
                        result += ch;
                    }
                }
                else
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        result += (char)(ch + ('a' - 'A'));
                    }
                    else
                    {
                        result += ch;
                    }
                }
            }

            Console.WriteLine("Converted sentence:");
            Console.WriteLine(result);
        }
    }
}
