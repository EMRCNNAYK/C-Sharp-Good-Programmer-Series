

namespace Constructors { 

class Program
{
    static void Main(String[] args)
    {
        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ",
            City = "Ankara",
        };

        Customer customer2 = new Customer(22, "Derin", "Demiroğ", "Ankara");
        Console.WriteLine(customer2.FirstName);
    }

    class Customer
    {

        public Customer()
        {

        }
            //default constructor
        public Customer(int id, string firstName, string lastname, string city)
        {
            // Console.WriteLine("Yapıcı blok çalıştı.");
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            City = city;

        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
}