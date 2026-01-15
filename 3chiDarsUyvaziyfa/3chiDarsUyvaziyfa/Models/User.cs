using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Models;

public class User
{
    public Guid UserId { get; set; }
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public int PhoneNamber {  get; set; }
    public int Age { get; set; }
}
