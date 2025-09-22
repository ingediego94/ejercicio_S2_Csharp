namespace ejercicio_S2_Csharp.Models
{
    public class Customer : Person
    {
        
        // Properties for Customer: (Adding: Id_customer, Age, Dni)
        public string Role { get; set; } 

        
        
        // Constructor method that calls to constructor of the basis class (Person):
        public Customer(Guid idCustomer, string name, string lastname, string email, string password, string dni, int age, string role)
            : base(idCustomer, name, lastname, email, password, dni, age)
        {
            Role = role;
        }

        public void Login()
        {
            Console.WriteLine($"Login Clientes \nCustomer Info: {Name} {Lastname}, Email: {Email}, Age: {Age}");
        }   
        
        
        
        
    }
}