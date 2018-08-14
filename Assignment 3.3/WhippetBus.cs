/*Zachary Miller
 * 11/18/2017
 * assignment 3.3
 * The purpose of this program is to have the user enter a distance in miles and then display the appropiate ticket price
 * WhippetBus.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    class WhippetBus
    {
        static void Main(string[] args)
        {
            uint tripDistance = getInput();
            double price = determinePrice(tripDistance);
            displayOutput(tripDistance, price);
            Console.ReadKey();
        }

        private static uint getInput()
        {
            Boolean correctInput;
            uint mileage=0;
            do
            {
                Console.Write("Please enter your trip distance in miles: ");
                string input = Console.ReadLine();
                try
                {
                    mileage = uint.Parse(input);
                    correctInput = true;
                }
                catch (FormatException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX: 250. \n");
                }
                catch(OverflowException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX:");
                }
            } while (correctInput == false);
            return mileage;
        }

        private static double determinePrice(uint tripDistance)
        {
            double price;
            if (tripDistance <= 100)
                price = 25.00;
            else if (tripDistance > 100 && tripDistance <= 299)
                price = 40.00;
            else if (tripDistance > 299 && tripDistance <= 499)
                price = 55.00;
            else if (tripDistance > 499)
                price = 70.00;
            else
                price = 0.00;
            return price;
        }

        private static void displayOutput(uint distance, double price)
        {
            Console.WriteLine("Your total price for travelling {0} miles is ${1}.", distance, price);
            
        }
    }
}
