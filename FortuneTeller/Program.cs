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
            int birthMonth;
            string favoriteColor;
            int numberSiblings;
            bool playGame = true;

            //Header
            Console.WriteLine("******************************");
            Console.WriteLine("**    THE FORTUNE TELLER    **");
            Console.WriteLine("******************************\n");

            //User Input
            Console.WriteLine("I will tell you your fortune based on answers to some questions.");
            Console.WriteLine("You may enter EXIT at any time to exit the game.");
            Console.WriteLine("Let's begin...");
            Console.WriteLine();


            do
            {

            } while (playGame);

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();
            Console.Write("What is your age? (Please enter a number): ");
            age = int.Parse(Console.ReadLine());
            Console.Write("What is your birth month? (Please enter as a number between 1 and 12): ");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color? ");
            Console.Write("Please enter R, O, Y, G, B, I, V or Help for a list of colors: ");
            favoriteColor = Console.ReadLine();

            //If help is entered, display help menu and ask user again for a color
            if(favoriteColor.ToLower() == "help")
            {
                Console.WriteLine();
                Console.WriteLine("Enter R if your favorite color is RED");
                Console.WriteLine("Enter O if your favorite color is ORANGE");
                Console.WriteLine("Enter Y if your favorite color is YELLOW");
                Console.WriteLine("Enter G if your favorite color is GREEN");
                Console.WriteLine("Enter B if your favorite color is BLUE");
                Console.WriteLine("Enter I if your favorite color is INDIGO (dark blue)");
                Console.WriteLine("Enter V if your favorite color is VIOLET (purple)");
                Console.WriteLine();
                Console.WriteLine("What is your favorite ROYGBIV color? ");
                Console.Write("Please enter R, O, Y, G, B, I, or V: ");
                favoriteColor = Console.ReadLine();
            }
            Console.Write("How many siblings do you have? ");
            numberSiblings = int.Parse(Console.ReadLine());

            //Variables for the fortune
            int yrsToRetire;
            string vacHome;
            string transportation;
            string moneyInBank;

            //Retirement years
            if (age % 2 == 0)
            {
                yrsToRetire = 23;
            }
            else
            {
                yrsToRetire = 6;
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
                        vacHome = "an unknown location";
                        break;
                }
            }

            //Tranportation
            switch (favoriteColor.ToLower())
            {
                case "r":
                    transportation = "Corvette";
                    break;
                case "o":
                    transportation = "Subaru";
                    break;
                case "y":
                    transportation = "Vespa";
                    break;
                case "g":
                    transportation = "mini van";
                    break;
                case "b":
                    transportation = "Camaro";
                    break;
                case "i":
                    transportation = "Tesla";
                    break;
                case "v":
                    transportation = "Saab";
                    break;
                default:
                    transportation = "unknown vehicle";
                    break;
            }

            //Money in Bank
            if (birthMonth < 1 || birthMonth > 12)
            {
                moneyInBank = "$0.00";
            }
            else if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = "$10,483";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = "$230,230";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = "$41,623,000";
            }
            else
            {
                moneyInBank = "an unknown amount";
            }

            //Output the fortune
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("{0} {1} will retire in {2} year(s)\n" +
                "with {3} in the bank,\n" +
                "a vacation home in {4},\n" +
                "and a(n) {5}.", 
                firstName, lastName, yrsToRetire, moneyInBank, vacHome, transportation);
            Console.WriteLine("******************************");

        } //Main()

        public void exitProgram()
        {
            //If the user enters 'exit' at any time, the program will exit
        }
    }
}
