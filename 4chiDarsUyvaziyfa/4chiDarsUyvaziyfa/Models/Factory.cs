using System;
using System.Collections.Generic;
using System.Text;

namespace _4chiDarsUyvaziyfa.Models;

public class Factory
{
    public string Brend {  get; set; }
    public string Name { get; set; }
    public string Year {  get; set; }
    public string Color { get; set; }
    public decimal Pric {  get; set; }

    public Factory()
    {
        Console.WriteLine("Factory ishladi");
    }
}
