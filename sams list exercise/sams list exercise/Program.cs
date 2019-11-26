using System;

namespace samslistexercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            List myList = new List();
            
            for (int i = 0; i < 4; i++)
            {
                ListExercises list1 = new ListExercises();

                Console.WriteLine("Enter a name");
                list1.SetName(Console.ReadLine());

                if (myList.AddName(list1) == true)
                {
                    Console.WriteLine("Person Added");
                }
                else
                {
                    Console.WriteLine("No more space");
                    Console.ReadLine();
                }
                Console.WriteLine("Enter a name to find the position of: ");
                string personToFindPositionOf = Console.ReadLine();
                Console.WriteLine(personToFindPositionOf + "'s position is " + myList.GetPosition(personToFindPositionOf));

            }
        }
    }
}
