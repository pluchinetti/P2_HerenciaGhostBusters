using System;

namespace Herencia
{
    public class Person
    {
        public string FirstName {get;}
        public string LastName {get;}
        public string EmailAddr {get;}
        /// <summary>
        /// Permite construir un nuevo objeto cuyo tipo hereda de la clase Person.
        /// </summary>
        /// <param name="firstName">Nombres de la persona.</param>
        /// <param name="lastName">Apellidos de la persona.</param>
        /// <param name="email">Dirección de email de la persona.</param>
        public Person (string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddr = email;
        }
    }
}