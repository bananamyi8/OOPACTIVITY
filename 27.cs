using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2777
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int currentNumber = 1;

            for (int i = 1; i <= rows; i++) 
            {
                for (int j = 1; j <= i; j++) 
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
        }
    }
}
