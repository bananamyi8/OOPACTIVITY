using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age in years: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 1 && age <= 120)
            {
            int months = age * 12;
            Console.WriteLine("You are " + months + " months old.");
            }
            else
            {
            Console.WriteLine("Age must be between 1 and 120.");
            }
        }
    }

}
