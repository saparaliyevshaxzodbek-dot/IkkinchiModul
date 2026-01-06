using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1chiDars;

public class Product
{
    public Guid GuidOfProduct { get; set; }
    public string ProductName { get; set; }
    public int  Price { get; set; }
    public string Description { get; set; }
    public DateTime date {  get; set; }


    override public string ToString()
    {
        return $"Guid: {GuidOfProduct}\nName: {ProductName}\nPrice: {Price}\nDate: {date}\nDescription: {Description}\n";
    }


}
