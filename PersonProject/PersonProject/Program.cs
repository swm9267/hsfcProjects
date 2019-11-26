using System;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Console.WriteLine("What is your name?");
            p1.SetName(Console.ReadLine());
            Console.WriteLine("How old are you?");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(p1);

            Address a1 = new Address();
            Console.WriteLine("What country do you live in?");
            a1.SetCountry(Console.ReadLine());
            Console.WriteLine("What city do you live in?");
            a1.SetCity(Console.ReadLine());
            Console.WriteLine("What is the name of your street?");
            a1.SetStreetName(Console.ReadLine());
            Console.WriteLine("What is your house number?");
            a1.SetHouseNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("What is your post code?");
            a1.SetPostCode(Console.ReadLine());

            Console.Write(p1);Console.Write(a1)
                Console.ReadLine();
        }
    }
}
