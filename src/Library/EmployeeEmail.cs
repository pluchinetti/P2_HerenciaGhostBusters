using System;

namespace Herencia
{
    public class EmployeeEmail : Email
    {
        public Employee Employee {get; set;}

        public EmployeeEmail(Employee employee, string from, string subject)
        : base (employee, from, subject)
        {
            this.Employee = employee
            this.Body = $"Estimado {this.Employee.FirstName} {this.Employee.LastName} ..."
        }
    }
}