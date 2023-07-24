using System.Linq;
using System;
using System.Collections.Generic;

//https://www.codewars.com/kata/565f1bd8f97d3e59c400014a

public class BinaryFingers
{
    public static string[] GetFingers(string binary)
    {
        string[] fingers = { "Pinkie", "Ring", "Middle", "Index", "Thumb" };
        List<string> result = new List<string>();
        binary = string.Join("", Enumerable.Repeat("0", fingers.Length - binary.Length)) + binary;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
                result.Add(fingers[i]);
        }
        return result.Count == 0 ? new string[] { } : result.ToArray();
    }
}