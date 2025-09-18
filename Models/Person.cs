namespace ejercicio_S2_Csharp.Models;

public class Person
{
    // common properties to chidren classes
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    
    // Constructor
    public Person(string name, string lastname, string email, string password)
    {
        Name = name;
        Lastname = lastname;
        Email = email;
        Password = password;
    }
    
    

    
    
}