namespace ejercicio_S2_Csharp.Models;

public class Concert
{
    public int Id_Concert { get; set; }
    public DateTime Date { get; set; }
    public string location { get; set; }
    public int capacity { get; set; }

    public List<string> Artists { get; set; } = new List<string>();

}