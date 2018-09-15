using System;
using System.Collections;

namespace Herencia
{
    public class Catalogue : IEnumerable
    {
        private IList catalogue = new ArrayList();

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