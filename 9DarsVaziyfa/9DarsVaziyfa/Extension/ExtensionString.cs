namespace _9DarsVaziyfa.Extension;

public static class ExtensionString
{
    //2-misol
    //public static int CountNumber(this string str)
    //{
    //    var count = 0;

    //    for (var i = 0; i < str.Length; i++)
    //    {
    //        if(char.IsDigit(str[i]))
    //        {
    //            count++; 
    //        }
    //    }
    //    return count;
    //}
    //3-misol

    //public static bool BigString(this string str)
    //{
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        if(char.IsUpper(str[i]))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //4-miso
    public static bool SmolString(this string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if(char.IsLower(str[i]))
            {
                return true;
            }
        }
        return false;
    }

}
