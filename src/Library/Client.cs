using System;

namespace Herencia
{
    public class Client : Person
    {
        public string Address {get;}
        /// <summary>
        /// Permite crear un nuevo objeto de la clase Client que hereda de la clase Person.
        /// </summary>
        /// <param name="firstName">Nombres del cliente.</param>
        /// <param name="lastName">Apellidos del cliente.</param>
        /// <param name="emailAddr">Dirección de email del cliente.</param>
        /// <param name="address">Dirección/zona donde vive.</param>
        public Client (string firstName, string lastName, string emailAddr, string address) 
            : base(firstName, lastName, emailAddr) 
            {
                this.Address = address;
            }
    }
}