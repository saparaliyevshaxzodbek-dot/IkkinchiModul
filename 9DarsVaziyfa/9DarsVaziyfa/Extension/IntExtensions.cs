using System;
using System.Collections.Generic;
using System.Text;

namespace _9DarsVaziyfa.Extension;

public static class IntExtensions
{
    //1-misol
    //public static bool check(this int value)
    //{
    //    if(value >  0)
    //    {
    //        return true;
    //    }
    //    return false;
    //}

    //2-misol
    //public static string  check(this  int value)
    //{
    //    if(value >= 18 )
    //    {
    //        return "Balog'at yoshiga yetgan";
    //    }
    //    else
    //    {
    //        return "Balog'at yoshiga yetmagan";

    //    }
    //}

    //3-misol

    public static string check(this int value)
    {
        if(value % 2 == 0)
        {
            return "Son juft";
        } else
        {
            return "son Toq";
        }

    }
}
