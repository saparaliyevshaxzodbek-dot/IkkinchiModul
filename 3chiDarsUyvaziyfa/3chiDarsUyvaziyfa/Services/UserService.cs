using _3chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Services;

public class UserService
{
    List<User> Users = new List<User>();

    public Guid AddUser(User user)
    {
        user.UserId = Guid.NewGuid();
        Users.Add(user);
        return user.UserId;
    }

    public User? GetUserById(Guid userId)
    {
        foreach(var user in Users)
        {
            if(user.UserId == userId)
            {
                return user;
            }
        }
        return null;

    }

    public bool DeleteUser(Guid userId)
    {
        foreach( var user in Users)
        {
            if(user.UserId == userId)
            {
                Users.Remove(user);
                return true;
            }
        }
        return false;
    }

    public List<User> GetAllUsers()
    {
        return Users; 
    }

    public bool UpdateUser(Guid userId , User newuser)
    {
        var user = GetUserById(userId);
        if(user == null)
        {
            return false;
        }
        user.Age = newuser.Age;
        user.PhoneNamber = newuser.PhoneNamber;
        user.FirsName = newuser.FirsName;
        user.LastName = newuser.LastName;

        return true;
    }
}
