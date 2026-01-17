using _5chiDars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5chiDars.Service
{
    public class CountrService
    {
        List<Countr> Countrs;
        public CountrService()
        {
            Countrs = new List<Countr>();
        }

        public Guid AddCountr(Countr countr)
        {
            Guid coutrId = Guid.NewGuid();
            Countrs.Add(countr);
            return countr.CountrId;
        }

        public Countr? GetCountrById(Guid countrId)
        {
            foreach (var countr in Countrs)
            {
                if(countr.CountrId == countrId)
                {
                    return countr;
                }
            }

            return null;
        }

        public bool DeleteCountr(Guid countrId)
        {
            foreach(var countr in Countrs)
            {
                if(countr.CountrId == countrId)
                {
                    Countrs.Remove(countr);
                    return true;
                }
            }
            return false;
        }

        public List<Countr> GetAllCoutr()
        {
            return Countrs; 
        }

        public bool UpdateCountr(Guid countrId, Countr newcountr)
        {
            var countr = GetCountrById(countrId);
            if(countr == null)
            {
                return false;
            }

            countr.Capacty = newcountr.Capacty;
            countr.CountrName = newcountr.CountrName;

            return true;


            
        }
    }
}
