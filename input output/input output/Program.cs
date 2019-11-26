using System;

namespace input_output
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int c = 0;
            string userchoice = "";
            string add = "add";
            string volume = "volume";
            string average = "average";

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type 'add' to add numbers, 'average' to find the average of the numbers or 'volume' to find the volume of the numbers in litres if they were cm lengths on a cuboid");
            userchoice = Console.ReadLine();
            if (userchoice == add)
            {
                Console.WriteLine(a + b + c);
            }
            else { }
            if (userchoice == average)
            {
                Console.WriteLine((a + b + c) / 3);
            }
            else { }
            if (userchoice == volume)
                Console.WriteLine((a * b * c) / 1000);
            else { }
            Console.ReadKey();



        }
    }
}
