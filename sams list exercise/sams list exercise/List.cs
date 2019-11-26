using System;
using System.Collections.Generic;
using System.Text;

namespace samslistexercise
{
    public class List
    {
        string personToFindPositionOf = "";
        private ListExercises[] contents = new ListExercises[3];
        private int nextFreeLocation = 0;

        public bool AddName(ListExercises theListExercises)
        {
            if (nextFreeLocation < contents.Length)
            {
                contents[nextFreeLocation] = theListExercises;
                nextFreeLocation = nextFreeLocation + 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetPosition(string personToFindPositionOf)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (personToFindPositionOf == contents[i].GetName())
                {
                    return i;
                }
            }
            return -1;
        }
        public Boolean RemoveByPosition(int thePosition)
        {

        }
    }
}
