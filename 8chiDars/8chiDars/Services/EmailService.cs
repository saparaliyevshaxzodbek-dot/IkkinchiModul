using System;
using System.Collections.Generic;
using System.Text;

namespace _8chiDars.Services;

using _8chiDars.Models;


public class EmailService : IEmailServise
{
    List<Email> Emails = new List<Email>();

    public Guid AddEmail(Email email)
    {
        Guid guid = Guid.NewGuid();
        Emails.Add(email);
        return email.EmailId;
    }

    public bool DeleteEmail(Guid emailId)
    {
        foreach(Email email in Emails)
        {
            if(email.EmailId == emailId)
            {
                Emails.Remove(email);
                return true;
            }
        }
        return false;
    }

    public List<Email> GetAll()
    {
        return Emails;
    }

    public Email? GetEmailById(Guid emailId)
    {
        foreach (Email email in Emails)
        {
            if(email.EmailId == emailId)
            {
                return email;
            }
        }
        return null;
    }

    public bool UpdateEmail(Guid emailId, Email email)
    {
        foreach(var newemail in Emails)
        {
            if(newemail.EmailId == emailId)
            {
                email.EmailName = newemail.EmailName;
                email.EmailAddress = newemail.EmailAddress;

                return true;
            }
        }
        return false;
    }

    public void SendNotification()
    {
        Console.WriteLine("Hamma xodimlarga emaildan notification ketdi");
    }
}
