https://www.codewars.com/kata/54fb963d3fe32351f2000102
public class Kata
{
    public static int Collatz(int n)
    {
        int array = 0;
        while (n > 1)
        {
            if (n % 2 == 0)
                n = n / 2;
            else
                n = n * 3 + 1;
            array++;
        }
        return ++array;
    }
}