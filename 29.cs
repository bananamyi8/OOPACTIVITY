using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;

            while (true)
            {
                Console.Write("Enter start integer: ");
                bool validStart = int.TryParse(Console.ReadLine(), out start);

                Console.Write("Enter end integer: ");
                bool validEnd = int.TryParse(Console.ReadLine(), out end);

                if (!validStart || !validEnd)
                {
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                    continue;
                }

                if (start >= end)
                {
                    Console.WriteLine("Start must be less than end. Try again.");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
