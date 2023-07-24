https://www.codewars.com/kata/588a3c3ef0fbc9c8e1000095

using System;
public class Kata
{
    public static int MaxDiff(int[] list)
    {
        if (list.Length == 0) 
            return 0; 
        Array.Sort(list);
        int dif = list[list.Length - 1] - list[0];
        return dif;
    }
}