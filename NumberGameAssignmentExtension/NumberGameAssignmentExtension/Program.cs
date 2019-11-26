using System;

namespace NumberGameAssignmentExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber = 0;
            intNumber = rnd.Next(1, 11);
            int intGuess = 0;
            int intCount = 0;
            do
            {
                Console.WriteLine("Guess the number from 1-10:");
                intCount = intCount + 1;
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess > intNumber)
                {
                    Console.WriteLine("Too high!");
                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Too low!");
                }
                if (intGuess == intNumber)
                {
                    Console.WriteLine("Correct! You got it in " + (intCount) + " guesses");
                }
            } while (intGuess != intNumber);
            Console.ReadLine();
        }
    }
}
