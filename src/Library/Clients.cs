using System;
using System.Collections;

namespace Herencia
{
    public class Clients : IEnumerable
    {
        private IList clients = new ArrayList();
        /// <summary>
        /// Añade un objeto de tipo Client a la lista en cuestión.
        /// </summary>
        /// <param name="client">Cliente que será añadido a la lista.</param>
        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }

        public IEnumerator GetEnumerator()
        {
            return this.clients.GetEnumerator();
        }
    }
}