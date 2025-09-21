using Microsoft.VisualBasic.CompilerServices;
using ejercicio_S2_Csharp.Models;
using ejercicio_S2_Csharp.Services;

namespace ejercicio_S2_Csharp.Services;

public class ConcertsCrud
{

    // List that storage all concenrts:
    private static List<Concert> concerts = new List<Concert>();
    
    
    // Method to Register a new concert:
    public static void RegisteringConcert()
    {

        
        // Establishing a date by default:
        DateTime tempDate = default;
        
        Console.WriteLine("CREAR NUEVO CONCIERTO.");
        
        Guid idConcert = Guid.NewGuid();
        Console.WriteLine($"Id del concierto: {idConcert}");
        
        Console.WriteLine("Nombre del nuevo concierto: ");
        string concertName = Console.ReadLine().Trim();

        Console.WriteLine("Ciudad del concierto: ");
        string city = Console.ReadLine().Trim();
        
        DateTime date = DatesHoursFunc.ReturnDate(tempDate);
        
        Console.WriteLine("Capacidad máxima de personas: ");
        int capacity = GeneralFunc.TryConvertInputToNumber();

        string again = "no";
        
        // List to storage artists:
        var artists = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Escribe los artistas asistentes (uno por uno): ");
            
            string artist = Console.ReadLine().Trim();

            if (!string.IsNullOrEmpty(artist))
            {
                artists.Add(artist);
            }

            Console.WriteLine("\tDeseas agregar otro artista? (si/no)");
            again = Console.ReadLine().ToLower();

            if (again != "si") break;
        }

        // Adding a new concert
        var newConcert = new Concert
        {
            Id_Concert = idConcert,
            ConcertName = concertName,
            Date = date,
            City = city,
            Capacity = capacity,
            Artists = artists
        };

        concerts.Add(newConcert);
        
        Console.WriteLine("\nConcierto creado correctamente. \nResumen de datos:");
        
        ConcertResume(newConcert);
        
    }


    
    // Method to see concert's resume:
    public static void ConcertResume(Concert newConcert_y)
    {
        Console.WriteLine($"  Id concierto: {newConcert_y.Id_Concert}");
        Console.WriteLine($"  Nombre del concierto: {newConcert_y.ConcertName}.");
        Console.WriteLine($"  Fecha: {newConcert_y.Date.ToString("F")}.");
        Console.WriteLine($"  Capacidad máxima: {newConcert_y.Capacity}.");
        Console.WriteLine($"  Ciudad: {newConcert_y.City}");
        Console.WriteLine($"  Total de artistas: {newConcert_y.Artists.Count}");
        foreach (var i in newConcert_y.Artists)
        {
            Console.WriteLine($"    - {i}");
        }

        Console.WriteLine(new string('-',30));
    }
    
    
    
    
    // Method to List all concerts:
    public static void ListingConcerts()
    {
        Console.WriteLine("LISTAR TODOS LOS CONCIERTOS.");

        if (concerts.Count() > 0 )
        {
            Console.WriteLine($"Total de conciertos: {concerts.Count()}");

            foreach (var oneConcert in concerts)
            {
                Console.WriteLine($"  Id concierto: {oneConcert.Id_Concert}.");
                Console.WriteLine($"  Nombre del concierto: {oneConcert.ConcertName}.");
                Console.WriteLine($"  Fecha: {oneConcert.Date.ToString("F")}.");
                Console.WriteLine($"  Capacidad máxima: {oneConcert.Capacity}.");
                Console.WriteLine($"  Ciudad: {oneConcert.City}");
                Console.WriteLine($"  Total de artistas: {oneConcert.Artists.Count}");
                Console.WriteLine(new string('-',30));
            }

            Console.WriteLine("Fin del listado");
            Console.WriteLine(new string('=',30));
        }
        else
        {
            Console.WriteLine($"No hay información que mostrar, el total de conciertos registrados es {concerts.Count()}");
        }
    }
    
    
    
    public static void EditingConcert()
    {
        Console.WriteLine("EDITAR UN CONCIERTO.");

        
    }
    
    
    
    public static void DeletingConcert()
    {
        Console.WriteLine("ELIMINAR CONCIERTOS.");
        
        while (true)
        {
            Console.WriteLine("Escribe el ID del concierto que deseas eliminar: ");
            
            string imputGuid = Console.ReadLine().Trim();
            
            if (Guid.TryParse(imputGuid, out Guid idToDelete))
            {
                Console.WriteLine($"ID válido: {idToDelete}");
                
                // To search the ID concert:
               var concertToDelete = concerts.FirstOrDefault(c => c.Id_Concert == idToDelete);
            
                if (concertToDelete != null)
                {
                    concerts.Remove(concertToDelete);
                    Console.WriteLine("Borrando...");
                    //bdd38755-acaa-440d-b077-284a4d16aa0b
                    Console.WriteLine("Concierto borrado.");
                    break;
                }
                else
                {
                    Console.WriteLine("No se encontró el concierto con ese ID.");
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("El ID ingresado no es válido. Intenta de nuevo.");
                Console.ResetColor();
                
            }


        }
        
    }
}