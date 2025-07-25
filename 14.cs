using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0 || age > 130)
                {
                    Console.WriteLine("Unable to compute grade. Please enter your age between 1-130.");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("Child");
                }
                else if (age <= 19)
                {
                    Console.WriteLine("Teen");
                }
                else if (age <= 59)
                {
                    Console.WriteLine("Adult");
                }
                else if (age <= 60)
                {
                    Console.WriteLine("Senior");
                }
        }
    }
}

