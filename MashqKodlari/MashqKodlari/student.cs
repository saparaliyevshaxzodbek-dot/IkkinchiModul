using System;
using System.Collections.Generic;
using System.Text;

namespace MashqKodlari;

public class student
{
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone  { get; set; }
    public DateTime Birthday { get; set; }


 // methods

    public int CalculateAge()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - Birthday.Year;
        return age;
    }




  public void HelloG13()
    {
        Console.WriteLine("Hello G13");
    }

    public void PrintPhone()
    {
        Console.WriteLine($"Student Phone : {Phone}");
    }


    public override string ToString()
    {
        return $"Id : {StudentId}\n FN : {FirstName} \n LN : {LastName}\n Email : {Email} \n PhoneNumber : {Phone}";
    }
    

}
