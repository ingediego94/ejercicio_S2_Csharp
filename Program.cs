using System;
using ejercicio_S2_Csharp.Models;
using ejercicio_S2_Csharp.Services;

namespace ejercicio_S2_Csharp;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of customer:
        var customers = new List<Customer>();
        
        
        Customer customer1 = new Customer(
            idCustomer:1,
            name:"diego",
            lastname:"vallejo",
            email:"dieego@gmail.com", 
            password:"golf2047*", 
            age:30, 
            dni:"1085310"
            );
        // -------------------------------------------------------
        
        // Creating an instance of Admin:
        Admin admin = new Admin(
            idAdmin:3,
            name:"Edd",
            lastname:"Klauss",
            email:"ed.klauss@gmail.com",
            password:"12345rea"
            
            );
        
        Console.WriteLine(admin.Id_admin);

        customer1.Login();
        
        GeneralFunc.Menu();
        

    }

}