using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username, password;

            do
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();

                Console.Write("Enter password: ");
                password = Console.ReadLine();

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Try again\n");
                }

            } while (username != "admin" || password != "1234");
        }
    }
}
