using System;

namespace month_days1
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "";
            string numberofdays = "" ;
            Console.WriteLine("Enter month (capitalise first letter): ");
            month = Console.ReadLine();
            switch (month)
            {
                case "January": numberofdays = "31"; break;
                case "February": numberofdays = "28"; break;
                case "March": numberofdays = "31"; break;
                case "April": numberofdays = "30"; break;
                case "May": numberofdays = "31"; break;
                case "June": numberofdays = "30"; break;
                case "July": numberofdays = "31"; break;
                case "August": numberofdays = "31"; break;
                case "September": numberofdays = "30"; break;
                case "October": numberofdays = "31"; break;
                case "November": numberofdays = "30"; break;
                case "December": numberofdays = "31"; break;
            }
               Console.WriteLine("The month " + month + " has " + numberofdays + " days.");
            Console.ReadKey();
            Console.ReadLine();

            }
    }
}
