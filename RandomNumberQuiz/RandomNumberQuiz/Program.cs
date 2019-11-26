using System;

namespace RandomNumberQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber0 = 0;
            int intNumber1 = 0;
            int intNumber2 = 0;
            int intNumber3 = 0;
            int intNumber4 = 0;
            int intNumber5 = 0;
            int intNumber6 = 0;
            int intNumber7 = 0;
            int intNumber8 = 0;
            int intNumber9 = 0;
            int intNumber10 = 0;
            int intNumber11 = 0;
            int intNumber12 = 0;
            int intNumber13 = 0;
            int intNumber14 = 0;
            int intNumber15 = 0;
            int intNumber16 = 0;
            int intNumber17 = 0;
            int intNumber18 = 0;
            int intNumber19 = 0;
            intNumber0 = rnd.Next(1, 101);
            intNumber1 = rnd.Next(1, 101);
            intNumber2 = rnd.Next(11, 101);
            intNumber3 = rnd.Next(1, 101);
            intNumber4 = rnd.Next(1, 11);
            intNumber5 = rnd.Next(1, 11);
            intNumber6 = rnd.Next(1, 21);
            intNumber7 = rnd.Next(1, 6);
            intNumber8 = rnd.Next(1, 21);
            intNumber9 = rnd.Next(1, 6);
            intNumber10 = rnd.Next(1, 101);
            intNumber11 = rnd.Next(1, 101);
            intNumber12 = rnd.Next(11, 101);
            intNumber13 = rnd.Next(1, 101);
            intNumber14 = rnd.Next(1, 11);
            intNumber15 = rnd.Next(1, 11);
            intNumber16 = rnd.Next(1, 21);
            intNumber17 = rnd.Next(1, 6);
            intNumber18 = rnd.Next(1, 21);
            intNumber19 = rnd.Next(1, 6);
            int intAnswer0 = (intNumber0 + intNumber1);
            int intAnswer1 = (intNumber2 - intNumber3);
            int intAnswer2 = (intNumber4 * intNumber5);
            int intAnswer3 = (intNumber6 / intNumber7);
            int intAnswer4 = (intNumber8 % intNumber9);
            int intAnswer5 = (intNumber10 + intNumber11);
            int intAnswer6 = (intNumber12 - intNumber13);
            int intAnswer7 = (intNumber14 * intNumber15);
            int intAnswer8 = (intNumber16 / intNumber17);
            int intAnswer9 = (intNumber18 % intNumber19);
            int intGuess = 0;
            string UserName = "";
            int UserScore = 0;
            Console.WriteLine("Hello, you get 2 points for a first time guess, 1 for second time guess and -1 if wrong after 2 tries, Enter your name:");
            UserName = Console.ReadLine();
            Console.WriteLine("What is " + (intNumber0) + " + " + (intNumber1) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer0)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber0) + " + " + (intNumber1) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer0)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber2) + " - " + (intNumber3) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer1)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber2) + " - " + (intNumber3) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer1)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber4) + " x " + (intNumber5) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer2)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber4) + " x " + (intNumber5) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer2)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber6) + " DIV " + (intNumber7) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer3)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber6) + " DIV " + (intNumber7) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer3)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber8) + " MOD " + (intNumber9) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer4)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber8) + " MOD " + (intNumber9) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer4)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber10) + " + " + (intNumber11) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer5)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber10) + " + " + (intNumber11) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer5)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber12) + " - " + (intNumber13) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer6)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber12) + " - " + (intNumber13) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer6)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber14) + " x " + (intNumber15) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer7)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber14) + " x " + (intNumber15) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer7)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber16) + " DIV " + (intNumber17) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer8)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber16) + " DIV " + (intNumber17) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer8)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            Console.WriteLine("What is " + (intNumber18) + " MOD " + (intNumber19) + "?");
            intGuess = Convert.ToInt32(Console.ReadLine());
            if (intGuess == intAnswer9)
            {
                Console.WriteLine("Correct! 2 points!");
                UserScore = UserScore + 2;
            }
            else
            {
                Console.WriteLine("What is " + (intNumber18) + " MOD " + (intNumber19) + "?");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess == intAnswer9)
                {
                    Console.WriteLine("Correct! 1 point!");
                    UserScore = UserScore + 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. -1 point.");
                    UserScore = UserScore - 1;
                }
            }
            switch (UserScore)
            {
                case -10:
                case -9:
                case -8:
                case -7:
                case -6:
                case -5:
                case -4:
                case -3:
                case -2:
                case -1:
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Unlucky " + UserName + ", You got " + UserScore + " Point(s).");
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Console.WriteLine("Well done " + UserName + ", You got " + UserScore + " Points.");
                    break;
                case 20:
                    Console.WriteLine("Congratulations " + UserName + "! You got all " + UserScore + " Points.");
                    break;

            }

            Console.ReadLine();
        }
    }
}
