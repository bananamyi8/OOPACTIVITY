using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0-999): ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0 || number > 999)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 999.");
                return;
            }

            if (number == 0)
            {
                Console.WriteLine("Zero");
                return;
            }

            string words = "";

            int hundreds = number / 100;
            int remainder = number % 100;

            if (hundreds > 0)
            {
                words += NumberToWords(hundreds) + " Hundred";
                if (remainder > 0)
                    words += " ";
            }

            if (remainder > 0)
            {
                if (remainder < 20)
                {
                    words += NumberToWords(remainder);
                }
                else
                {
                    int tens = remainder / 10;
                    int ones = remainder % 10;
                    words += TensToWords(tens);
                    if (ones > 0)
                        words += " " + NumberToWords(ones);
                }
            }

            Console.WriteLine(words);
        }

        static string NumberToWords(int n)
        {
            switch (n)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "";
            }
        }

        static string TensToWords(int n)
        {
            switch (n)
            {
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: return "";


            }
        }
    }
}

