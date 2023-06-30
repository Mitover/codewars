using System;
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
