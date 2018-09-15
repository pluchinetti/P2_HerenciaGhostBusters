using System;
using System.Collections;

namespace Herencia
{
    public class DB : IEnumerable
    {
        private IList clients = new ArrayList();
        private IList employees = new ArrayList();
        private IList catalogue = new ArrayList();


        public void AddClient(Client client)
        {
            this.clients.Add(client);
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void AddCD (CD cd)
        {
            this.catalogue.Add(cd);
        }

        public IList GetCDByGenre(string genre)
        {
            IList result = new ArrayList();
            foreach(CD cd in this.catalogue)
            {
                if(cd.Genre.Equals(genre))
                    result.Add(cd);
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return this.catalogue.GetEnumerator();
        }
    }
}