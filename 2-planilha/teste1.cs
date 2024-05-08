using System;

class Program
{
static void Main(string[] args)
{

    Console.WriteLine("Informe o valor do investimento:");
    double presente = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe a taxa(formato decimal):");
    double taxa = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Informe o período (meses):");
    int meses = Convert.ToInt32(Console.ReadLine());

    double futuro = presente * Math.Pow(1 + taxa/100, meses);

    Console.WriteLine($"O valor do investimento é: {futuro:C2}");
}

}