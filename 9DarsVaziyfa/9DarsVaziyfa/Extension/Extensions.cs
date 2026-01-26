using System;
using System.Collections.Generic;
using System.Text;

namespace _9DarsVaziyfa.Extension;

public static class Extensions
{
    public static string RemuveNumber(this string str)
    {
        for(var i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                str = str.Remove(i, 1);
                --i;

            }
        }
        return str;
    }

}
