namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Jake");
            person.Introduce("Mosh");

            var customer = new Customer();
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

        }
    }
}
