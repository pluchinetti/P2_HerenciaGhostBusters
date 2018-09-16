using System;
using System.Collections;

namespace Herencia
{
    class Program
    {
        static void Main (string[] args)
        {   
            // ===================== Inicialización e impresión de los datos del sistema =====================
            // --------------------------- Inicialización de los datos del sistema ---------------------------
            Clients clients = InitializeSystem.Clients();
            Employees employees = InitializeSystem.Employees();
            Catalogue catalogue = InitializeSystem.Catalogue();

            // ------------------------ Impresión en consola de los datos almacenados ------------------------
            SystemPrinters.ClientPrinter(clients);      // Imprime los datos de los clientes registrados.
            SystemPrinters.EmployeePrinter(employees);  // Imprime los datos de los empleados registrados.
            SystemPrinters.CataloguePrinter(catalogue); // Imprime los datos de los discos registrados.
            // ===============================================================================================

            // ======================================= Envío de email ========================================
            Console.WriteLine("¿Desea probar la funcionalidad de envío de emails (Y/N)?");
            if (Console.ReadLine().ToLower() == "y")
            {               
                // ---------------------- Credenciales para el envío de email ----------------------
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
             
                // ------------------- Personas para el envío de email (ver nota) ------------------
/*                 Client targetClient = new Client ("Julio", "Suaya", "jcsl19@hotmail.com", "Carrasco");
                Employee targetEmployee = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735"); */
                Client targetClient = new Client ("Julio", "Suaya", "pluchinetti@gmail.com", "Carrasco");
                Employee targetEmployee = new Employee ("Pablo", "Luchinetti", "pluchinetti@live.com", 25, "47405029");
                // Nota: Se declaron estas "nuevas" personas para el envío de email, ya que no se 
                //       logró acceder a ellas desde las listas previamente creadas, utilizando 
                //       un índice. Se agradece cualquier comentario acerca de cómo mejorar esto. :)
                            
                // ----------------------- Objetos de email y envío de estos -----------------------
                EmailSender ems = new EmailSender(fromAddr, password);  // Genera el objeto que permitira el envío de email
                                                                        // con las credenciales provistas.
                
                // Se crean los objetos emails con base en las plantillas previamente definidas.
                ClientEmail emailToClient = new ClientEmail(targetClient, fromAddr, "GhostBusters - ¿Te has olvidado de nosotros?");
                EmployeeEmail emailToEmployee = new EmployeeEmail(targetEmployee, fromAddr, "GhostBusters - ¡Excelentes noticias!");
                
                // Envío de los emails previamente definidos.
                ems.SendEmail(emailToClient.FromAddress, "GhostBusters LLC - Atención al Cliente", emailToClient.To.EmailAddr, emailToClient.Subject, emailToClient.Body);
                ems.SendEmail(emailToEmployee.FromAddress, "GhostBusters - Capital Humano", emailToEmployee.To.EmailAddr, emailToEmployee.Subject, emailToEmployee.Body);
                
                // Se informa al usuario que se enviaron correctamente (en teoría) los emails.
                Console.WriteLine("===================================================================================================");
                Console.WriteLine("Los emails se deberían haber enviado correctamente a los primeros empleado y cliente registrados.");
            }
            else
                Console.WriteLine("That's all folks!");
            // ===============================================================================================
        }
    }
}
    