using System;

namespace Herencia
{
    public class EmployeeEmail : Email
    {
        public Employee Employee {get; set;}
        
        /// <summary>
        /// Plantilla para el envío de email a un empleado.
        /// </summary>
        /// <param name="employee">Objeto Employee que recibirá el email.</param>
        /// <param name="from">Dirección de email del remitente.</param>
        /// <param name="subject">Asunto del email.</param>
        public EmployeeEmail(Employee employee, string from, string subject)
        : base (employee, from, subject)
        {
            this.Employee = employee;
            this.Body = $"Estimado {this.Employee.FirstName} {this.Employee.LastName}: Deseamos informarte que has sido ascendido. ¡Felicitaciones!";
        }
    }
}