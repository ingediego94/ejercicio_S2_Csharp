namespace ejercicio_S2_Csharp.Models;

public class Person
{
    // common properties to chidren classes
    public Guid Id { get; set; } 
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Dni { get; set; }
    public int Age { get; set; }
    
    
    // Constructor
    public Person(Guid id, string name, string lastname, string email, string password, string dni, int age )
    {
        Id = id;
        Name = name;
        Lastname = lastname;
        Email = email;
        Password = password;
        Dni = dni;
        Age = age;
    }
    
    // Registering method:
    public static Person Register()
    {
        Console.WriteLine("---   Registrar   ---");

        // ID:
        Guid id = new Guid();
        
        
        // NAME:
        string name;
        do
        {
            Console.Write("Nombre:  ");
             name = Console.ReadLine().Trim().ToLower();
        } while (string.IsNullOrEmpty(name));

        
        // LASTNAME
        string lastname;
        do
        {
            Console.Write("Apellido:  ");
            lastname = Console.ReadLine().Trim().ToLower();
        } while (string.IsNullOrEmpty(lastname));
        
        

        //EMAIL
        string email;
        do
        {
            Console.Write("Email:  ");
            email = Console.ReadLine().Trim().ToLower();
        } while (string.IsNullOrEmpty(email) || !email.Contains('@'));

        
        //PASSWORD
        string password;
        do
        {
            Console.Write("Contraseña:  ");
            password = Console.ReadLine().Trim();
        } while (string.IsNullOrEmpty(password) || password.Length < 5);


        // DNI
        string dni;
        do
        {
            Console.Write("DNI:  ");
            dni = Console.ReadLine().Trim(); 
        } while (string.IsNullOrEmpty(dni) || dni.Length < 5);
        
        
        // AGE
        int age;
        do
        {
            Console.Write("Edad (0 < edad > 120):");
        } while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 120);

        
        // Create an object with imput data:
        Person newPerson = new Person(id, name, lastname, email, password, dni, age);


        Console.WriteLine("\n REGISTRADO CON EXITO ");
        Console.WriteLine($"ID: {newPerson.Id}");
        Console.WriteLine($"Nombre completo: {newPerson.Name} {newPerson.Lastname}.");
        Console.WriteLine($"Edad: {newPerson.Age}");
        Console.WriteLine($"Email: {newPerson.Email}");
        Console.WriteLine($"DNI: {newPerson.Dni}");

        return newPerson;
    }
    
    
}