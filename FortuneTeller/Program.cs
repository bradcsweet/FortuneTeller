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

            Console.WriteLine("Greetings. \nI am the legendary fortune teller BALTHAZAR. \nLet me ask you a series of questions and I'll tell you your fortune!");

            Console.WriteLine("\nPress \"enter\" to begin.");
            Console.ReadLine();

            Console.WriteLine("\nLet's start with your first name. What is it?");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nGreat. Now what is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nWhat is your age?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHmm...Interesting. \nWhat is your birth month as a number 1-12?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is your favorite ROYGBIV color? \nType \"Help\" if you need a list of these colors.");
            string favColor = Console.ReadLine().ToLower();

            Console.WriteLine("\nThis does not bode well so far. Perhaps this will help; \nHow many siblings do you have?");
            int siblingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhen you're ready, press \"enter\" and I'll tell you your fortune.");
            Console.ReadLine();
            Console.WriteLine("\nRemember... I'm only the messenger");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("This is your fortune!");




       
        }
    }
}
