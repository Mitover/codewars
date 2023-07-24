https://www.codewars.com/kata/576b93db1129fcf2200001e6


using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        return (numbers == null || numbers.Length == 0) ? 0 : numbers.Sum() - numbers.Max() - numbers.Min();
    }
}
