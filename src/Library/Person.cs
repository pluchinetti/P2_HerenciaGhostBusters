using System;

namespace Herencia {

    public abstract class Person {
        private String name;

        private String lastname;

        private String mail;

        public Person (String name, String lastname, String mail) {
            this.name = name;
            this.lastname = lastname;
            this.mail = mail;

        }

    }
}