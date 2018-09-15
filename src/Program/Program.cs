using System;

namespace Herencia
{
    class Program {



        static void Main (string[] args)
        {
            Console.WriteLine("¿Desea probar la funcionalidad de envío de emails (Y/N)?");
            if (Console.ReadLine() == "Y")
            {
                Employee guillermo = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735");
                Employee pablo = new Employee ("Pablo", "Luchinetti", "pluchinetti@live.com", 25, "47405029");

                Client julio = new Client ("Julio", "Suaya", "jcsl19@hotmail.com", "Carrasco");
                Client camila = new Client ("Camila", "González", "camigonpal2@gmail.com", "Barra de Carrasco");
                Client camilo = new Client ("Camilo", "Peña", "camilo.pm.28@gmail.com", "Parque Miramar");
                // ====================== Credenciales para el envío de email ======================
                
                // Versión 1 - Credenciales en el código (hard-coded)
                /*
                string fromAddr = "<<Ingresar nombre de usuario>>@gmail.com";
                string password = "<<Ingresar contraseña>>";
                */

                // Versión 2 - Solicita al usuario sus credenciales
                Console.WriteLine("Ingrese el email del remitente (solo Gmail): ");
                string fromAddr = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña del remitente: ");
                string password = Console.ReadLine();
                // =================================================================================
                Console.WriteLine("Ingrese el nombre de un cliente (ver clientes registrados):" );
                string inputClient = Console.ReadLine().ToLower();
                Console.WriteLine("Ingrese el nombre de un empleado (ver empleados registrados):" );
                string inputEmployee = Console.ReadLine().ToLower();

                switch(inputClient)
                {
                    case "julio":
                        Client targetClient = julio;
                        break;
                    case "camila":
                        Client targetClient = camila;
                        break;
                    case 

                }

                
            }


/*             EmailSender ems = new EmailSender(fromAddr, password);
            EmployeeEmail emailToEmployee = new EmployeeEmail(guillermo, fromAddr, "GhostBusters - Licencias y marcas");

            ems.SendEmail(fromAddr, "GhostBusters LLC", emailToEmployee.To.EmailAddr, emailToEmployee.Subject, emailToEmployee.Body); */

            Clients clients = new Clients();

            clients.AddClient(julio);
            clients.AddClient(camila);
            clients.AddClient(camilo);

            SystemPrinters.ClientPrinter(clients);  // Imprime los datos de los clientes registrados.

            Employees employees = new Employees();

            employees.AddEmployee(guillermo);
            employees.AddEmployee(pablo);

            SystemPrinters.EmployeePrinter(employees);  // Imprime los datos de los empleados registrados.



        }

      


        /*private static void InitializeCDs () {
            disks.AddCD (
                    new CD ("Powerslave", "Heavy metal", 1984, "Iron Maiden", new String[] { "Aces High", "2 minutes to Midnight", "Losfer Words" })); 
            }
        }
        */
    }
}
    