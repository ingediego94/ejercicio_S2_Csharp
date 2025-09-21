using System.Runtime.InteropServices.JavaScript;
using ejercicio_S2_Csharp.Models;

namespace ejercicio_S2_Csharp.Services;

public class Concert
{
    public Guid Id_Concert { get; set; }
    public string ConcertName { get; set; }
    public DateTime Date { get; set; }
    public string City { get; set; }
    public int Capacity { get; set; }
    public List<string> Artists { get; set; } = new List<string>();
    
}