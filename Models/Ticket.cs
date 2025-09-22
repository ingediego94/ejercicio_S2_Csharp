namespace ejercicio_S2_Csharp.Models;

public class Ticket
{
    public Guid Id_ticket {get; set; }
    public decimal Price { get; set; }
    public string Locality { get; set; }
    public DateTime Date { get; set; }
}