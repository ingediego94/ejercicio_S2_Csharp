using System;
using ejercicio_S2_Csharp.Models;
using ejercicio_S2_Csharp.Services;

namespace ejercicio_S2_Csharp;

using static Concert;       // To call a class without point 
using static Services.ConcertsCrud;

public class Program
{
    // public static int Login()
    // {
    //     // menu para saber quien va a iniciar // var type;
    //     
    //     // Verificar correo
    //     // Verificar contraseña
    //     // Iniciar sesión usando type para saber a que menu acceder.
    //     
    //     // menuArtist();
    //     // menuAdmin();
    //     // menuCustomer();
    //     
    //     CreateConcert();
    // }
    
    
    public static void Main(string[] args)
    {
        GeneralFunc.Menu();
        

        
        
        
        // Customer customer1 = new Customer(
        //     idCustomer:1,
        //     name:"diego",
        //     lastname:"vallejo",
        //     email:"dieego@gmail.com", 
        //     password:"golf2047*", 
        //     age:30, 
        //     dni:"1085310"
        //     );
        // // -------------------------------------------------------
        //
        // // Creating an instance of Admin:
        // Admin admin = new Admin(
        //     idAdmin:3,
        //     name:"Edd",
        //     lastname:"Klauss",
        //     email:"ed.klauss@gmail.com",
        //     password:"12345rea"
        //     
        //     );
        
        //customer1.Login();

    }

}