using System;

namespace Herencia
{
    class Program {

        // private static Library disks = new Library ();
        static void Main (string[] args)
        {
            string fromAddr = "<<Ingresar nombre de usuario>>@gmail.com";
            string password = "<<Ingresar contraseña>>";

            Employee pablo = new Employee ("Pablo", "Luchinetti", "pluchinetti@live.com", 25, "47405029");
            Employee guillermo = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735");
            Client julio = new Client ("Julio", "Suaya", "jcsl19@hotmail.com", "Carrasco");
            Client camila = new Client ("Camila", "González", "camigonpal2@gmail.com", "Barra de Carrasco");
            Client camilo = new Client ("Camilo", "Peña", "camilo.pm.28@gmail.com", "Parque Miramar");

            EmailSender ems = new EmailSender(fromAddr, password);
            EmployeeEmail emailToEmployee = new EmployeeEmail(guillermo, fromAddr, "GhostBusters - Licencias y marcas");

            ems.SendEmail(fromAddr, "GhostBusters LLC", emailToEmployee.To.EmailAddr, emailToEmployee.Subject, emailToEmployee.Body);

        }

        /*private static void InitializeCDs () {
            disks.AddCD (
                    new CD ("Powerslave", "Heavy metal", 1984, "Iron Maiden", new String[] { "Aces High", "2 minutes to Midnight", "Losfer Words" })); 
            }
        }
        */
    }
}
    