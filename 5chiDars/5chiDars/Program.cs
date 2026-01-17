
using _5chiDars.Models;
using _5chiDars.Service;

namespace _5chiDars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountryService countryService = new CountrService();
            Countr countr = new Countr()
            {
                CountrName = "Countr",
                Capacty = 13
            };
        }
    }
}
