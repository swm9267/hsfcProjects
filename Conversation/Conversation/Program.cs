using System;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "";
            int Userage = 0;
            int Currentyear = 0;
            string Userschool = "";
            int UserFutureAge = Userage + 10;
            int UserFutureAgeGuess = 0;

            Console.WriteLine("Hello, What is your name: ");
            Username = Console.ReadLine();
            Console.Write("Enter your age: ");
            Userage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the current year: ");
            Currentyear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where do you go to School: ");
            Userschool = Console.ReadLine();
            Console.WriteLine("Hello {0}. Your age is {1}, you were born in {2}, and you go to school at {3}.", Username, Userage, Currentyear - Userage, Userschool);
            Console.Write("How old will you be in 10 years: ");
            UserFutureAge = Userage + 10;
            UserFutureAgeGuess = Convert.ToInt32(Console.ReadLine());
            if (UserFutureAgeGuess == UserFutureAge)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            Console.ReadKey();

                }
    }
}
