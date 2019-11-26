using System;

namespace ListExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string names = new string[];
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("Enter a name:");
                names[i] = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
