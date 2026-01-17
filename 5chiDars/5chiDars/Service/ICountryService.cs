using _5chiDars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5chiDars.Service
{
    public interface ICountryService
    {
        public Guid AddCountery(Countr countr);
        public bool UpdateCountry(Countr countr);
        public bool DeleteCountry(Countr countryId);
        public Countr? GetCountrById(Guid countrId);
        public List<Countr> GetCountrs();
    }
}
