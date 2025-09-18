using System;
using ejercicio_S2_Csharp.Models;

namespace Ejercicio_S2_Csharp;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of customer:
        Customer customer = new Customer(1,"diego","vallejo", "dieego@gmail.com", "golf2047*", 30, "1085310");

        Console.WriteLine(customer.Name);
    }

}