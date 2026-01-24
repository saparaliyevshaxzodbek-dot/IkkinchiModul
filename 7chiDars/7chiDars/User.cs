using System;
using System.Collections.Generic;
using System.Text;

namespace _7chiDars;

public class User
{

    public string PhoneNamber
    {
        get
        {
            return PhoneNamber;
        }
        set
        {  
            value = PhoneNamber;
        }
    }

    private Guid userid;

    public Guid  UserId
    {
        get { return userid; }
        set { userid = value; }
    }



    private string username;

    public string UserName
    {
        get { return username; }
        set { username = value; }
    }



    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }



    private string lastname;

    public string LastName
    {
        get { return lastname; }
        set { lastname = value; }
    }

    private string firstname;

    public string FirstName
    {
        get { return firstname; }
        set { firstname = value; }
    }

    

}
