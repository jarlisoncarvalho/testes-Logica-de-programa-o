 using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        double c = (a + b) / 2;
        c -= 40;

        int[] v = new int[3];
        v[0] = a;
        v[1] = b;
        v[2] = (int)c;

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine("v[" + i + "] = " + v[i]);
        }
    }
}
