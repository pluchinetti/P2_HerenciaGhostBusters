using System;

namespace Herencia
{
    public class Employee : Person
    {
        public int Age {get;}
        public string PerID {get;}
        /// <summary>
        /// Permite crear un nuevo objeto de la clase Employee que hereda de la clase Person.
        /// </summary>
        /// <param name="firstName">Nombres del empleado.</param>
        /// <param name="lastName">Apellidos del empleado.</param>
        /// <param name="emailAddr">Dirección de email del empleado.</param>
        /// <param name="age">Edad del empleado.</param>
        /// <param name="perID">Nº de C. I. del empleado.</param>
        public Employee (string firstName, string lastName, string emailAddr, int age, string perID) 
        : base (firstName, lastName, emailAddr) {
            this.Age = age;
            this.PerID = perID;
        }

    }
}