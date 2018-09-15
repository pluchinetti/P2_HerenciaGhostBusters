using System;

namespace Herencia
{
    public class Person
    {
        private string FirstName {get;}
        private string LastName {get;}
        private string EmailAddr {get;}

        public Person (string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddr = email;
        }
    }
}