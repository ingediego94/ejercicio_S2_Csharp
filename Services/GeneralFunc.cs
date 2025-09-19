using System;
using System.ComponentModel;
using System.Globalization;

namespace ejercicio_S2_Csharp.Services
{

    public class GeneralFunc
    {
        
        // TO SHOW MAIN MENU:
        public static void Menu()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('=', 30));
                Console.WriteLine("|       RIWI MUSIC MENU      |");
                Console.WriteLine(new string('=', 30));
                Console.ResetColor();
                Console.WriteLine(
                    "1) Gestión de conciertos.\n2) Gestión de clientes. \n3) Gestión de tiquetes. \n4) Historial de compras. \n5) Consultas avanzadas (LINQ). \n0) Salir.");
                Console.Write("\nEscribe la opción que deseas realizar:  ");
                
                int optionMainMenu = TryConvertInputToNumber();
                
                // Execute action according to the option:
                if (SelectOptionMainMenu(optionMainMenu))
                {
                    break; // if return "true", it means that chosen exit.
                }

                Console.WriteLine("\nPresiona ENTER para volver al menú..."); // +++++++++++++++
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static int TryConvertInputToNumber()
        {
            int toNumber;

            while (true)
            {
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out toNumber))
                {
                    return toNumber;
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nOpción inválida. Ingrese un número.");
                Console.ResetColor();
            }
        }
        
        // TO SELECT THE OPTION ON THE MAIN MENU:
        public static bool SelectOptionMainMenu(int option_x)
        {
            int optionSpecificMenu;
            
            switch (option_x)
            {
                case 1:
                    Console.WriteLine("1) Gestión de Conciertos:");
                    ConcertsManagement();
                    break;
                case 2:
                    Console.WriteLine("2) Gestión de Clientes:");
                    ClientsManagement();
                    break;
                case 3:
                    Console.WriteLine("3) Gestión de Tiquetes:");
                    TicketsManagement();
                    break;
                case 4:
                    Console.WriteLine("4) Historial de Compras:");
                    PurchaseHistory();
                    break;
                case 5:
                    Console.WriteLine("5) Consultas Avanzadas (LINQ):");
                    AdvancedQueries();
                    break;
                case 0:
                    Console.WriteLine("6) Saliendo del sistema...");
                    Exiting();
                    return true;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opción errada. Intente de nuevo.");
                    Console.ResetColor();
                    break;
            }

            return false;   
        }
        
        
        
        // TO SELECT THE SPECIFIC OPTION ON THE MENU
        
        // 1) Manager concerts:
        public static void ConcertsManagement()
        {
            Console.WriteLine("\t1) Registrar concierto. \n\t2) Listar conciertos. \n\t3) Editar concierto. \n\t4) Eliminar concierto.");
            Console.Write("\nEscribe la opción que deseas realizar:  ");
            int opSpecMenu = TryConvertInputToNumber();
            
            switch (opSpecMenu)
            {
                case 1:
                    Console.WriteLine("RegisteringConcert()");
                    break;
                case 2:
                    Console.WriteLine("ListingConcerts()");
                    break;
                case 3:
                    Console.WriteLine("EditingConcert()");
                    break;
                case 4:
                    Console.WriteLine("DeletingConcert");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opción no válida.");
                    Console.ResetColor();
                    break;
            }
        }
        
        
        
        // 2) Clients Management:
        public static void ClientsManagement()
        {
            Console.WriteLine("ClientsManagement()");
            
            Console.WriteLine("\t1) Registrar cliente. \n\t2) Listar clientes. \n\t3) Editar cliente. \n\t4) Eliminar cliente.");
            Console.Write("\nEscribe la opción que deseas realizar:  ");
            int opSpecMenu = TryConvertInputToNumber();
            
            // hacer switch
        }
        
        
        
        // 3) Tickets Management:
        public static void TicketsManagement()
        {
            Console.WriteLine("TicketsManagement()");
            
            Console.WriteLine("\t1) Registrar compra de tiquete. \n\t2) Listar tiquetes vendidos. \n\t3) Editar compra. \n\t4) Eliminar compra.");
            Console.Write("\nEscribe la opción que deseas realizar:  ");
            int opSpecMenu = TryConvertInputToNumber();
            
            // hacer switch
        }
        
        
        
        // 4) Purchase History:
        public static void PurchaseHistory()
        {
            Console.WriteLine("PurchaseHistory()");
            
            // hacer funcion para historial de compras
        }
        
        
        // 5) Advanced Queries:
        public static void AdvancedQueries()
        {
            Console.WriteLine("AdvancesQueries()");
            
            Console.WriteLine("\t1) Consultar clientes por ciudad. \n\t2) Consultar conciertos por rango de fechas. \n\t3) Consultar el concierto con as tiquetes vendidos. " +
                              "\n\t4) Consultar ingresos totales de un concierto. \n\t5) Consultar cliente con más compras realizadas.");
            Console.Write("\nEscribe la opción que deseas realizar:  ");
            int opSpecMenu = TryConvertInputToNumber();
            
            // hacer switch
        }

        
        // 6) Exiting
        public static void Exiting()
        {
            Console.WriteLine("Salir");
        }
    }

}