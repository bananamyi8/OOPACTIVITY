using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

                if ((grade == 0))
                    Console.WriteLine("Unable to compute grade.");
                {
                if (grade >= 100)
                    Console.WriteLine("Unable to compute grade. Please enter a number between 1-100.");
                else if (grade >= 90)
                        Console.WriteLine("Your grade is: A");
                else if (grade >= 80)
                        Console.WriteLine("Your grade is: B");
                else if (grade >= 70)
                        Console.WriteLine("Your grade is: C");
                else if (grade >= 60)
                        Console.WriteLine("Your grade is: D");
                else if (grade <= 60)
                        Console.WriteLine("Your grade is: F");
                }
        }
    }
}
