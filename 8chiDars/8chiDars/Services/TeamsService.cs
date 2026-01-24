using System;
using System.Collections.Generic;
using System.Text;

namespace _8chiDars.Services;

using _8chiDars.Models;


public class TeamsService : IEmailServise
{
    public Guid AddEmail(Email email)
    {
        throw new NotImplementedException();
    }

    public bool DeleteEmail(Guid emailId)
    {
        throw new NotImplementedException();
    }

    public List<Email> GetAll()
    {
        throw new NotImplementedException();
    }

    public Email? GetEmailById(Guid emailId)
    {
        throw new NotImplementedException();
    }

    public void SendDotNation()
    {
        Console.WriteLine("Hamma xodimlarga Teams notification ketdi");
    }

    public bool UpdateEmail(Guid emailId, Email email)
    {
        throw new NotImplementedException();
    }
}
