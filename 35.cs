using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string result = "";
            bool newWord = true;

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    result += ch;
                    newWord = true;
                }
                else if (newWord)
                {
                   
                    if (ch >= 'a' && ch <= 'z')
                        result += (char)(ch - ('a' - 'A'));
                    else
                        result += ch;

                    newWord = false;
                }
                else
                {
                   
                    if (ch >= 'A' && ch <= 'Z')
                        result += (char)(ch + ('a' - 'A'));
                    else
                        result += ch;
                }
            }

            Console.WriteLine("Formatted sentence:");
            Console.WriteLine(result); 
        }
    }
}
