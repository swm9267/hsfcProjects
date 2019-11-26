using System;

namespace Function_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber0 = 0;
            int intNumber1 = 0;
            int intGuess = 0;
            int UserScore = 0;
            void DisplayMenu()
            {
                Console.WriteLine("1. Addition ");
                Console.WriteLine("2. Subtraction ");
                Console.WriteLine("3. Multiplication ");
                Console.WriteLine("4. DIV ");
                Console.WriteLine("5. MOD");
                Console.WriteLine("6. Display score");
                Console.WriteLine("7. Quit");
            }
            int option = 0;
            string UserName = "";

            Console.WriteLine("Enter Username: ");
            UserName = Console.ReadLine();

            DisplayMenu();
            Console.WriteLine("please enter an option (1-7)");
            option = Convert.ToInt32(Console.ReadLine());
            while (option != 7)
            {
                switch (option)
                {
                    case 1:
                        Random rnd = new Random();
                        intNumber0 = rnd.Next(1, 101);
                        intNumber1 = rnd.Next(1, 101);
                        int intAnswer0 = (intNumber0 + intNumber1);

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
                        DisplayMenu();
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Random rnd1 = new Random();
                        intNumber0 = rnd1.Next(1, 101);
                        intNumber1 = rnd1.Next(1, 101);
                        int intAnswer1 = (intNumber0 - intNumber1);

                        Console.WriteLine("What is " + (intNumber0) + " - " + (intNumber1) + "?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == intAnswer1)
                        {
                            Console.WriteLine("Correct! 2 points!");
                            UserScore = UserScore + 2;
                        }
                        else
                        {
                            Console.WriteLine("What is " + (intNumber0) + " - " + (intNumber1) + "?");
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
                        DisplayMenu();
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Random rnd2 = new Random();
                        intNumber0 = rnd2.Next(1, 21);
                        intNumber1 = rnd2.Next(1, 21);
                        int intAnswer2 = (intNumber0 * intNumber1);

                        Console.WriteLine("What is " + (intNumber0) + " x " + (intNumber1) + "?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == intAnswer2)
                        {
                            Console.WriteLine("Correct! 2 points!");
                            UserScore = UserScore + 2;
                        }
                        else
                        {
                            Console.WriteLine("What is " + (intNumber0) + " x " + (intNumber1) + "?");
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
                        DisplayMenu();
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Random rnd3 = new Random();
                        intNumber0 = rnd3.Next(1, 51);
                        intNumber1 = rnd3.Next(1, 11);
                        int intAnswer3 = (intNumber0 / intNumber1);

                        Console.WriteLine("What is " + (intNumber0) + " DIV " + (intNumber1) + "?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == intAnswer3)
                        {
                            Console.WriteLine("Correct! 2 points!");
                            UserScore = UserScore + 2;
                        }
                        else
                        {
                            Console.WriteLine("What is " + (intNumber0) + " DIV " + (intNumber1) + "?");
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
                        DisplayMenu();
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Random rnd4 = new Random();
                        intNumber0 = rnd4.Next(1, 51);
                        intNumber1 = rnd4.Next(1, 11);
                        int intAnswer4 = (intNumber0 % intNumber1);

                        Console.WriteLine("What is " + (intNumber0) + " MOD " + (intNumber1) + "?");
                        intGuess = Convert.ToInt32(Console.ReadLine());
                        if (intGuess == intAnswer4)
                        {
                            Console.WriteLine("Correct! 2 points!");
                            UserScore = UserScore + 2;
                        }
                        else
                        {
                            Console.WriteLine("What is " + (intNumber0) + " MOD " + (intNumber1) + "?");
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
                        DisplayMenu();
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Well done " + UserName + " your score is: " + UserScore);
                        Console.WriteLine("please enter an option (1-7)");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}