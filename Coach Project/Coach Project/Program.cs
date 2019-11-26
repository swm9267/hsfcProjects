using System;

namespace Coach_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach();
            for(int i=0; i < 52; i++)
            {
                Person p = new Person();
                Console.WriteLine("Add person:");
                p.SetName(Console.ReadLine());
                if (myCoach.AddPerson(p) == true)
                    Console.WriteLine("Added");
                else
                    Console.WriteLine("Coach is full");
                Console.WriteLine("There are " + myCoach.GetNumOfPassengers() + " passengers currently on the coach");


                Console.WriteLine("Enter a name to find the seat of: ");
                string  passenger = Console.ReadLine();
                Console.WriteLine(passenger + "'s seat is seat number " + myCoach.GetSeatByName(passenger));
            }





            Console.ReadLine();
        }
    }
}
