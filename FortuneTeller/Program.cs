using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declarations
            string firstName;
            string lastName;
            int age;
            string birthMonth;
            int birthMonthNumber = 0;
            string favoriteColor;
            int numberSiblings;
            string input;

            //Header
            Console.WriteLine("******************************");
            Console.WriteLine("**    THE FORTUNE TELLER    **");
            Console.WriteLine("******************************\n");

            //
            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();
            Console.Write("What is your age? (Please enter a number between 1-120) ");
            input = Console.ReadLine();
            Int32.TryParse(input, out age);
            Console.Write("What is your birth month? ");
            birthMonth = Console.ReadLine();
            Console.WriteLine("What is your favorite color from the following list? ");
            Console.Write("Red, Orange, Yellow, Green, Blue, Indigo, Violet: ");
            favoriteColor = Console.ReadLine();
            Console.Write("How many siblings do you have? ");
            input = Console.ReadLine();
            Int32.TryParse(input, out numberSiblings);

            //Variables for the fortune
            int yrsToRetire = 4;
            string vacHome;
            string transportation;
            string moneyInBank;

            //Retirement years
            if (age % 2 == 0)
            {
                yrsToRetire = 23;
            }

            //Vacation home
            if (numberSiblings < 0)
            {
                vacHome = "Detroit";
            }
            else if (numberSiblings > 3)
            {
                vacHome = "Hawaii";
            }
            else
            {
                switch (numberSiblings)
                {
                    case 0:
                        vacHome = "Sanibel Island";
                        break;
                    case 1:
                        vacHome = "Denver";
                        break;
                    case 2:
                        vacHome = "Columbus";
                        break;
                    case 3:
                        vacHome = "Cancun";
                        break;
                    default:
                        vacHome = "I don't know";
                        break;
                }
            }

            //Tranportation
            switch (favoriteColor)
            {
                case "R":
                    transportation = "Corvette";
                    break;
                case "O":
                    transportation = "Subaru";
                    break;
                case "Y":
                    transportation = "Vespa";
                    break;
                case "G":
                    transportation = "mini van";
                    break;
                case "B":
                    transportation = "Camaro";
                    break;
                case "I":
                    transportation = "Tesla";
                    break;
                case "V":
                    transportation = "Saab";
                    break;
                default:
                    transportation = "I don't know";
                    break;
            }

            //Money in Bank
            if (birthMonthNumber < 1 || birthMonthNumber > 12)
            {
                moneyInBank = "$0.00";
            }
            else if (birthMonthNumber >= 1 && birthMonthNumber <= 4)
            {
                moneyInBank = "$10,483";
            }
            else if (birthMonthNumber >= 5 && birthMonthNumber <= 8)
            {
                moneyInBank = "$230,230";
            }
            else if (birthMonthNumber >= 9 && birthMonthNumber <= 12)
            {
                moneyInBank = "41,623,000";
            }
            else
            {
                moneyInBank = "I don't know";
            }

            //Output the fortune
            Console.WriteLine("{0} {1} will retire in {2} years\n" +
                "with {3} in the bank,\n" +
                "a vacation home in {4},\n" +
                "and a {5}.", 
                firstName, lastName, yrsToRetire, moneyInBank, vacHome, transportation);
            Console.ReadKey();
        }
    }
}
