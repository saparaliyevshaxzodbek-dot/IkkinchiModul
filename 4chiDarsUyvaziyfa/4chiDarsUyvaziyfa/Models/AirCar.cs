using System;
using System.Collections.Generic;
using System.Text;

namespace _4chiDarsUyvaziyfa.Models;

public class AirCar : Factory
{
    public int Capacity { get; set; }

    public AirCar()
    {
        Console.WriteLine("AirCar ishladi");
    }
 }
