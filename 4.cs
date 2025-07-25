using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a tempreature in celsius: ");
            float Celsius = float.Parse(Console.ReadLine());

            if ((Celsius <= 100 && Celsius >= -100))
            {
                float Fahrenheit = (Celsius * 9 / 5) + 32;
                Console.WriteLine($"The temperature in farenheit is: {Fahrenheit}");
            }
            else
            {
                Console.WriteLine("The temperature must be -100 and 100");
            }
        }
    }  

}
