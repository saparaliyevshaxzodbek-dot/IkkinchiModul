using _3chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Services;

public class PhoneService
{
    List<Phone> Phones = new List<Phone>();

    public Guid AddPhone(Phone phone)
    {
        phone.PhoneId = Guid.NewGuid();
        Phones.Add(phone);
        return phone.PhoneId;
    }

    public Phone? GetPhoneById(Guid phoneId)
    {
        foreach(var  phone in Phones)
        {
            if(phone.PhoneId == phoneId)
            {
                return phone; 
            }

        }
        return null;
    }

    public bool DeletePhone(Guid phoneId)
    {
        foreach (var phone in Phones)
        {
            if (phone.PhoneId == phoneId)
            {
                Phones.Remove(phone);
                return true;
            }
        }
        return false;
    }

    public List<Phone> GetAllPhones()
    {
        return Phones;
    }

    public bool  UpdatePhone(Guid phoneId , Phone newphone)
    {
        var phone = GetPhoneById(phoneId);

        if(phone == null)
        {
            return false;
        }
        phone.PhoneName = newphone.PhoneName;
        phone.Brend = newphone.Brend;
        phone.Price = newphone.Price;
        phone.Capacty = newphone.Capacty;
        phone.Color = newphone.Color;
        return true;
    }



}
