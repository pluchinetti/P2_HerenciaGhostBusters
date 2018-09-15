using System;
using System.Collections;

namespace Herencia
{
    public class Employees : IEnumerable
    {
        private IList employees = new ArrayList();

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public IEnumerator GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }
    }
}