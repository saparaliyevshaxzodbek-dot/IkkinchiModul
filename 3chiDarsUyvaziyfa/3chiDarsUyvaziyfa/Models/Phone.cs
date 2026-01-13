using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Models;

public class Phone
{
    public int Capacty { get; set; }
    public Guid PhoneId { get; set; }
    public string PhoneName { get; set; }
    public string Brend {  get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
}
