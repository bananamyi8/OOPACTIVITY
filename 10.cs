using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name required.");
                isValid = false;
            }
            if (!int.TryParse(ageInput, out int age) || age < 1 || age > 120)
            {
                Console.WriteLine("Invalid age.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Invalid email.");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("All fields are valid.");
            }
        }
    }
}
