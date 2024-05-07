using System;

class program
{
    static void Main(string[] args)
    {
        int a = 2;
        int[] v = new int[6];

        while (a < 6)
        {
            v[a] = 10 * a;
            a += 1;

        }
        for (int i = 0; i < 6 ; i++)
        {
            Console.WriteLine($"v[{i}] = { v[i]}");

        }
    }
}
