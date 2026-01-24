using _8chiDars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8chiDars.Services;

public interface IEmailServise
{
    public Guid AddEmail(Email email);
    public Email? GetEmailById(Guid emailId);
    public bool DeleteEmail(Guid emailId);
    public List<Email> GetAll();
    public bool UpdateEmail(Guid emailId,  Email email);

}
