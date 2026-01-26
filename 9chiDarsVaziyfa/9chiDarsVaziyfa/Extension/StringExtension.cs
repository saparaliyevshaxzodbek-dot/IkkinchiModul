using System;
using System.Collections.Generic;
using System.Text;

namespace _9chiDarsVaziyfa.Exrension;

public static class StringExtension
{
    public static string DeleteNumber(this string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                str = str.Remove(i);
                --i;
            }
        }
        return str;
    }
}
