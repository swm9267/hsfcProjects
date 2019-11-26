using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Person
    {
        private Address livesAt;
        private string name = "";
        private int age = 0;
        Address a1 = new Address();

        public Person (String theName, int theAge, Address theLivesAt)
        {
            name = theName;
            age = theAge;
            livesAt = theLivesAt;
        }

        public Person()
        {

        }
    
        public void SetName(String theName)
        {
            name = theName;
        }

        public String GetName()
        {
            return name;
        }

        public void SetAge(int theAge)
        {
            age = theAge;
        }

        public int GetAge()
        {
            return age;
        }
        
        public void SetLivesAt(Address theLivesAt)
        {
            livesAt = theLivesAt;
        }

        public Address GetLivesAt()
        {
            return livesAt;
        }

    
        public override string ToString()
        {
            return this.GetName() + " is aged " + this.GetAge() + " and lives at " + this.GetLivesAt();
        }
    }
}
