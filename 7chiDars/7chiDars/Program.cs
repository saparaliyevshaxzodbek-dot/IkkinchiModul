namespace _7chiDars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                UserId = Guid.NewGuid(),
                FirstName = "Azizov",
                LastName = "Aziz",
                Password = "1234",
                UserName = "asd"
                

            };


        }
    }
}
