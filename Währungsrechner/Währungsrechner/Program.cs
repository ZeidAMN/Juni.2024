using System;

namespace Währungsrechner
{
    internal class Program
    {
        static double ConvertDollarToEuro(double dollarAmount)
        {
            double exchangeRate = 0.93; // Beispiel-Wechselkurs: 1 USD = 0.93 EUR
            return dollarAmount * exchangeRate;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dollar - euro currency converter");

            while (true)
            {
                Console.Write("Please enter the amount in dollar ");
                if (double.TryParse(Console.ReadLine(), out double dollarAmount))
                {
                    double euroAmount = ConvertDollarToEuro(dollarAmount);
                    Console.WriteLine($"{dollarAmount} USD {euroAmount} EUR");
                }
                else
                {
                    Console.WriteLine("Invalid Input.Please enter a number..");
                }

                Console.Write("Do you want to do another conversion? (Yes No)");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                    break;
            }

            Console.WriteLine("Thank you for using the currency converter");
        }
    }
}