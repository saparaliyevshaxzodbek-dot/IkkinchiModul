using System;
using System.Collections.Generic;
using System.Text;

namespace _3chiDarsUyvaziyfa.Models;

public class Car
{
    public Guid CarId { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }
}
