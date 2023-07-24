using System;
//https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
public static class Kata
{
    public static int GetVowelCount(string str)
    {
    int vowelCount = 0;
    string glasns = "aeiou";
    for (int i = 0; i < str.Length; i++)
    {
        if (glasns.Contains(str[i]) )
            vowelCount++;
        /*if (vowels.IndexOf(str[i]) != -1)
                vowelCount++;*/  
    }
    return vowelCount;
    }
}
