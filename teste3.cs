using System;

class program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = a - 6;
        int[] v = new int[a];
        while (b < a)
        {
            v[b] = b + a;
            b = b + 2;
        }
        for(int i = 0; i<a; i++)
        {
            Console.WriteLine($"v[{i}] = {v[i]}");

        }
    }
}
