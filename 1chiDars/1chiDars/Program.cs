namespace _1chiDars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                GuidOfProduct = Guid.NewGuid(),
                ProductName = "Laptop",
                Price = 250,
                date =  DateTime.Now,
                Description = "Hello It is Laptop"
            };

            Console.WriteLine(product);
           
        }
    }
}
