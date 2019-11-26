using System;

namespace ConversionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Conversion myConvert = new Conversion();
            Console.WriteLine("Enter your string to reverse");
            String userString = Console.ReadLine();
            Console.WriteLine("The reverse is {0}", myConvert.ReverseString(userString));
        }
    }
}
