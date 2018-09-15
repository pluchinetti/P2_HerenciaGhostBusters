using System;

namespace Herencia
{
    public class Client : Person
    {
        public string Address {get;}
        
        public Client (string firstName, string lastName, string emailAddr, string address) 
            : base(firstName, lastName, emailAddr) 
            {
                this.Address = address;
            }
    }
}