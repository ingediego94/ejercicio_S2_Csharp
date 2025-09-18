namespace ejercicio_S2_Csharp.Models
{
    public class Customer : Person
    {
        // Properties for Customer: (Adding: Id_customer, Age, Dni)
        public int Id_customer { get; set; } 
        public int Age { get; set; }
        public string Dni { get; set; }

        
        // Constructor method that calls to constructor of the bais class (Person):
        public Customer(int idCustomer, string name, string lastname, string email, string password, int age, string dni)
            : base(name, lastname, email, password)
        {
            Id_customer = idCustomer;
            Age = age;
            Dni = dni;
        }

        public void Login()
        {
            Console.WriteLine($"Login Clientes \nCustomer Info: {Name} {Lastname}, Email: {Email}, Age: {Age}");
        }   
        
        
        
        
    }
}