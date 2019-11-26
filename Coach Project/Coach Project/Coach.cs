using System;
using System.Collections.Generic;
using System.Text;

namespace Coach_Project
{
    public class Coach
    {
        private string person = "";

        private Person[] contents = new Person[52];

        private int nextFreeLocation = 0;

        public string passenger = "";

        public Coach(String thePerson)
        {
            person = thePerson;
        }
        public Coach()
        {

        }

        public bool AddPerson(Person thePerson)
        {
            if(nextFreeLocation > 51)
            {
                return false;
            }
            contents[nextFreeLocation] = thePerson;
            nextFreeLocation++;
            return true;
        }




        public bool RemovePerson(Person thePerson)
        {
            if(nextFreeLocation < 0)
            {
                return false;
            }
            contents[nextFreeLocation] = thePerson;
            nextFreeLocation--;
            return true;
        }




        public int GetNumOfPassengers()
        {
            return nextFreeLocation;
        }

        public int GetSeatByName(string passenger)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (passenger == contents[i].GetName())
                {
                    return i;
                }
            }
        return -1;
        }

        public override int GetHashCode()
        {
            return this.GetNumOfPassengers();
        }


    }
}
