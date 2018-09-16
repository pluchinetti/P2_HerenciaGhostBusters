using System;

namespace Herencia
{
    public class SystemPrinters
    {
        /// <summary>
        /// Imprime en consola los datos de los clientes registrados, en forma ordenada.
        /// </summary>
        /// <param name="clients">Lista con objetos Cliente.</param>
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

        /// <summary>
        /// Imprime en consola los datos de los empleados registrados, en forma ordenada. 
        /// </summary>
        /// <param name="employees">Lista con objetos Employee.</param>
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

        /// <summary>
        /// Imprime en consola los datos de los discos registrados, en forma ordenada.
        /// </summary>
        /// <param name="catalogue">Catalogo con los discos disponibles.</param>
        public static void CataloguePrinter(Catalogue catalogue)
        {
            Console.WriteLine("========================= Discos registrados ==========================");

            foreach(CD cd in catalogue)
            {   
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"Artista: {cd.Artist} | Título: {cd.Name}");
                Console.WriteLine($"Género: {cd.Genre} | Año de publicación: {cd.Year}");
                Console.WriteLine("Canciones:");
                foreach(string song in cd.Songs)
                    Console.WriteLine("- "+song);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
    }
}