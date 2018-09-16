using System;

namespace Herencia
{
    
    public class InitializeSystem
    {
        /// <summary>
        /// Método que permite inicializar el sistema al registar los datos de unos clientes de prueba.
        /// </summary>
        /// <returns>Lista con objetos Client y sus respectivos datos.</returns>
        public static Clients Clients()
        {
            // -------------------------------------- Datos de clientes --------------------------------------
            Client julio = new Client ("Julio", "Suaya", "jcsl19@hotmail.com", "Carrasco");
            Client camila = new Client ("Camila", "González", "camigonpal2@gmail.com", "Barra de Carrasco");
            Client camilo = new Client ("Camilo", "Peña", "camilo.pm.28@gmail.com", "Parque Miramar");

            Clients clients = new Clients();
            clients.AddClient(julio);
            clients.AddClient(camila);
            clients.AddClient(camilo);

            return clients;
        }

        /// <summary>
        /// Método que permite inicializar el sistema al registar los datos de unos empleados de prueba.
        /// </summary>
        /// <returns>Lista con objetos Employee y sus respectivos datos.</returns>
        public static Employees Employees()
        {
            // ------------------------------------- Datos de empleados --------------------------------------
            Employee guillermo = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735");
            Employee pablo = new Employee ("Pablo", "Luchinetti", "pluchinetti@live.com", 25, "47405029");

            Employees employees = new Employees();
            employees.AddEmployee(guillermo);
            employees.AddEmployee(pablo);

            return employees;
        }

        /// <summary>
        /// Método que permite inicializar el sistema al registar los datos de unos discos de prueba.
        /// </summary>
        /// <returns>Lista con objetos CD y sus respectivos datos.</returns>
        public static Catalogue Catalogue()
        {
            // ------------------------------------- Datos de empleados --------------------------------------
            CD trapt = new CD ("Someone in Control","Post-grunge",2005,"Trapt", new string[] {
                "Disconnected (Out of Touch)","Waiting","Lost Realist","Use Me to Use You","Bleed Like Me"});
            CD rasmus = new CD ("Dead letters","Alternative rock",2003,"The Rasmus", new string[] {
                "In the Shadows","In My Life","First Day of My Life","Guilty"});
            
            Catalogue catalogue = new Catalogue();
            catalogue.AddCD(trapt);
            catalogue.AddCD(rasmus);

            return catalogue;
        }
    }

}