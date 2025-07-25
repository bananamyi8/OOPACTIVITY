using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int count = 0;

            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                    count++;
            }

            Console.WriteLine("Uppercase letters: " + count);
        }
    }
}
