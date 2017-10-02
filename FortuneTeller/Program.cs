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
            //console.readline()'s are used generously to control the pacing of the console and story.

            //userAge determines the value of retireAge; birthMonth to bankMoney; favColor to transportMode; and siblingNum to homeLocation

            Console.WriteLine("Greetings. \nI am the legendary fortune teller, BALTHAZAR. \nLet me ask you a series of questions and I'll tell you your fortune!");

            Console.WriteLine("\nPress \"enter\" to begin.");
            Console.ReadLine();

            Console.WriteLine("\nLet's start with your first name. What is it?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nGreat. Now what is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nWhat is your age?");
            int retireAge;
            int userAge = int.Parse(Console.ReadLine());

                if(userAge%2==0)
                {
                    retireAge = 12;
                }
                else
                {
                    retireAge = 31;
                }

            Console.WriteLine("\nHmm...Interesting. What is your birth month as a number 1-12?");
            string bankMoney;
            int birthMonth = int.Parse(Console.ReadLine());

                if (birthMonth <= 4 && birthMonth >= 1)
                {
                    bankMoney = "$43,032";
                }
                else if (birthMonth <= 8 && birthMonth >= 5)
                {
                    bankMoney = "$150,000";
                }
                else if (birthMonth <= 12 && birthMonth >= 9)
                {
                    bankMoney = "$50,000,000";
                }
                else
                {
                    bankMoney = "$0.00";
                }               

            Console.WriteLine("\nWhat is your favorite ROYGBIV color? \nType \"Help\" if you need a list of these colors.");
            string transportMode;
            string favColor = Console.ReadLine().ToLower();

                if (favColor == "red")
                {
                    transportMode = "Jaguar";
                }
                else if (favColor == "orange")
                {
                    transportMode = "bicycle";
                }
                else if (favColor == "yellow")
                {
                    transportMode = "tugboat";
                }
                else if (favColor == "green")
                {
                    transportMode = "yaht";
                }
                else if (favColor == "blue")
                {
                    transportMode = "hang-glider";
                }
                else if (favColor == "indigo")
                {
                    transportMode = "motorcycle";
                }
                else if (favColor == "violet")
                {
                    transportMode = "skateboard";
                }
                else if (favColor == "help")
                {
                    Console.WriteLine("\nYour choices include:\nred\norange\nyellow\ngreen\nblue\nindigo\nviolet");
                    Console.WriteLine("\nAfter you've chosen, I'll ask again.\nPress \"enter\" when ready!");
                    Console.ReadLine();
                    Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                    favColor = Console.ReadLine().ToLower();
                    if (favColor == "red")
                    {
                        transportMode = "Jaguar";
                    }
                    else if (favColor == "orange")
                    {
                        transportMode = "bicycle";
                    }
                    else if (favColor == "yellow")
                    {
                        transportMode = "tugboat";
                    }
                    else if (favColor == "green")
                    {
                        transportMode = "yaht";
                    }
                    else if (favColor == "blue")
                    {
                        transportMode = "hang-glider";
                    }
                    else if (favColor == "indigo")
                    {
                        transportMode = "motorcycle";
                    }
                    else if (favColor == "violet")
                    {
                        transportMode = "skateboard";
                    }
                    else
                    {
                        transportMode = "paper airplane";
                    }
                }
                else
                {
                transportMode = "rocketship";
                Console.WriteLine("My psychic intuition tells me you meant to type in \"green\", so we're going to proceed with that. ");
                }

            Console.WriteLine("\nOh my... This is not going to bode well for you. But perhaps this will help; \nHow many siblings do you have?");
            string homeLocation = ""; // Disclaimer- I don't know why homeLocation needs a value assigned here? None of the other variables above needed this...
            int siblingNumber = int.Parse(Console.ReadLine());
            if (siblingNumber >= 0 && siblingNumber <= 3)
            {
                switch (siblingNumber)
                {
                    case 0:
                        homeLocation = "Venice";
                        break;
                    case 1:
                        homeLocation = "the sandy shores of Hawaii";
                        break;
                    case 2:
                        homeLocation = "Switzerland";
                        break;
                    case 3:
                        homeLocation = "Alaska";
                        break;
                }
            }
            else
            {
                homeLocation = "the tar sands of North Dakota";
            }


            Console.WriteLine("\nWhen you're ready, press \"enter\" and I'll tell you your fortune.");
            Console.ReadLine();
            Console.WriteLine("\nRemember... I'm only the messenger. Once again, \"Enter\"");
            Console.ReadLine();

            // Part Three
            Console.Clear();
            Console.WriteLine("\aI, the GREAT BALTHAZAR shall now reveal your fortune!\a\n\n\n");
            Console.WriteLine(string.Concat(firstName," ",lastName," will retire in ",retireAge,
                " years with ", bankMoney, " in the bank, \na vacation home in ", homeLocation, " and a ", transportMode, "."));

                               
        }
    }
}
