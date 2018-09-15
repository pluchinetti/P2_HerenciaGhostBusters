using System;

namespace Herencia
{
    public class Person
    {
        public string FirstName {get;}
        public string LastName {get;}
        public string EmailAddr {get;}

        public Person (string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddr = email;
        }
    }
}