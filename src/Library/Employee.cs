using System;

namespace Herencia {

    public class Employee : Person {

        private String address;
        private Int32 age;
        private String perID;

        public Employee (String name, String lastname, String mail, Int32 age, String perID) 
        : base (name, lastname, mail) {
            this.age = age;
            this.perID = perID;
        }

    }

}