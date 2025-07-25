using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the price of the item: ");
                float price = float.Parse(Console.ReadLine());

                Console.Write("Enter the quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (price > 0 && quantity > 0)
                {
                    float total = price * quantity;
                    Console.WriteLine($"Total cost: Php {total}");
                }
                else
                {
                    Console.WriteLine("Error: Both price and quantity must be positive.");
                }
            
        }

    }
}