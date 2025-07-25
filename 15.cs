using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
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
                    Console.WriteLine("Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Grade: D");
                else if (grade <= 60)
                    Console.WriteLine("Grade: F");
            }
        }
    }
}