using System;
using System.Collections;

namespace Herencia
{
    public class Employees : IEnumerable
    {
        private IList employees = new ArrayList();

        /// <summary>
        /// Añade un objeto de tipo Employee a la lista en cuestión.
        /// </summary>
        /// <param name="employee">Empleado que será añadido a la lista.</param>
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