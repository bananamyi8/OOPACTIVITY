using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Number.");
                }
                else
                {
                    Console.WriteLine("Odd Number.");
                }
            }
            catch
            {
                Console.WriteLine("REJECT INTEGER");
            }
        }
    }
}
