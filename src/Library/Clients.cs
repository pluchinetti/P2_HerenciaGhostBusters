using System;
using System.Collections;

namespace Herencia
{
    public class Clients : IEnumerable
    {
        private IList clients = new ArrayList();

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