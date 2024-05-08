using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor presente: ");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.Write("informe o valor da taxa(em decimal): ");
        double taxa = double.Parse(Console.ReadLine());

        Console.Write("Determine o periodo presente: ");
        int periodoanos = int.Parse(Console.ReadLine());

        double valorFuturo = valorPresente * (Math.Pow((taxa / 100) + 1, periodoanos));

        Console.WriteLine($"O rendimento total foi: {valorFuturo:N}");
    }

}