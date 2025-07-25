using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool longEnough = password.Length >= 8;
            bool hasNumber = false;
            bool hasUpper = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c)) hasNumber = true;
                if (char.IsUpper(c)) hasUpper = true;
            }

            if (longEnough && hasNumber && hasUpper)
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password. Missing:");
                if (!longEnough) Console.WriteLine("At least 8 characters");
                if (!hasNumber) Console.WriteLine("the password must contain a number");
                if (!hasUpper) Console.WriteLine("must contain a capital letter");
            }
        }
    }
}
