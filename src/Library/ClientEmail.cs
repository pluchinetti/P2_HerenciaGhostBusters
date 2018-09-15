using System;

namespace Herencia
{
    public class ClientEMail : Email
    {
        public Client Client {get;}

        public ClientEMail(Client client, string from, string subject)
        : base(client, from, subject)
        {
            this.Client = client;
            this.Body = $"Estimado {this.Client.FirstName} {this.Client.LastName} ...";
        }
    }
}