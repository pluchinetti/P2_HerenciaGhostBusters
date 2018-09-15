using System;

namespace Herencia
{
    public class SystemPrinters
    {

        public static void ClientPrinter(Clients clients)
        {
            Console.WriteLine("======================== Clientes registrados =========================");

            foreach(Client client in clients)
            {   
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"Nombre: {client.FirstName} | Apellido: {client.LastName}");
                Console.WriteLine($"Email: {client.EmailAddr} | Dirección: {client.Address}");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }

        public static void EmployeePrinter(Employees employees)
        {
            Console.WriteLine("======================== Empleados registrados ========================");

            foreach(Employee employee in employees)
            {   
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"Nombre: {employee.FirstName} | Apellido: {employee.LastName}");
                Console.WriteLine($"Email: {employee.EmailAddr} | Edad: {employee.Age}");
                Console.WriteLine($"Nº de C. I.: {employee.PerID}");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        } 
    }
}