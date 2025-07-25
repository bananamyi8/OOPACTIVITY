using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a positive number: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                    return;
                }

                while (number >= 0)
                {
                    Console.WriteLine(number);
                    number--;
                }
            
        }

    }
}
