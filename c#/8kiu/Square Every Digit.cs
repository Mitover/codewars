using System;

public class Kata
{
 public static int SquareDigits(int n)
  {
    string a = n.ToString();
    string need="";
    for (int i = 0; i < a.Length; i++)
    {
        need += (int.Parse(a[i].ToString())* int.Parse(a[i].ToString())).ToString();
    }
    return int.Parse(need);
  }
}
