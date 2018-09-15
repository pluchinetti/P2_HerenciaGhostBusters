using System;

namespace Herencia
{
    public class Employee : Person
    {
        public int Age {get;}
        public string PerID {get;}

        public Employee (string firstName, string lastName, string emailAddr, int age, string perID) 
        : base (firstName, lastName, emailAddr) {
            this.Age = age;
            this.PerID = perID;
        }

    }
}