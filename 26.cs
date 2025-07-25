

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            int maxLength = 0;
            int currentLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    currentLength = 0;
                }
            }
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }

            Console.WriteLine($"Length of the longest word is: {maxLength}");
        }
    }

}
    

