using System;
using System.Collections.Generic;
using System.Text;

namespace _4chidars.Models;

public class Car
{
    public string Color { get; set; }
    public int Yesr { get; set; }
    public int speed { get; set; }


    public Car()
    {
        Console.WriteLine("Car ctor ishladi");
    }

}
