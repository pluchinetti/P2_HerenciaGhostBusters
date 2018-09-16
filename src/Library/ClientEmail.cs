using System;

namespace Herencia
{
    public class ClientEmail : Email
    {
        public Client Client {get;}
        
        /// <summary>
        /// Plantilla para el envío de email a un cliente.
        /// </summary>
        /// <param name="client">Objeto Client que recibirá el email.</param>
        /// <param name="from">Dirección de email del remitente.</param>
        /// <param name="subject">Asunto del email.</param>
        public ClientEmail(Client client, string from, string subject)
        : base(client, from, subject)
        {
            this.Client = client;
            this.Body = $"Estimado {this.Client.FirstName} {this.Client.LastName}: Hace mucho que no pasas por la sucursal, ¿qué pasa?";
        }
    }
}