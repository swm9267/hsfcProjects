using System;
using System.Collections.Generic;
using System.Text;

namespace samslistexercise
{
    public class ListExercises
    {
        private string name = "";

        public void SetName(String theString)
        {
            name = theString;
        }
        public String GetName()
        {
            return name;
        }
        public void RemoveName(String theString)
        {
            theString = "";
        }
    }
}
