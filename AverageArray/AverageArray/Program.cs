using System;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int numAboveAverage = 0;
            int numBelowAverage = 0;
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Please enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int averagenumbers = ((numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6] + numbers[7] + numbers[8] + numbers[9]) / 10);
            Console.WriteLine("the average of those numbers is " + averagenumbers);

            for (int i=0; i<10; i++)
            {
                if (averagenumbers > numbers[i])
                {
                    numBelowAverage = numBelowAverage + 1;
                }
                if (averagenumbers < numbers[i])
                {
                    numAboveAverage = numBelowAverage + 1;
                }
            }
        
                
            Console.WriteLine("There are " + numBelowAverage + " numbers below the average.");

            Console.ReadLine();
        }
    }
}
