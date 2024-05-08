using System;

class Program
{
    static void Main(string[] args)
    {
        double valorPresente = 3800;
        double taxa = 1.25;
        int meses = 5;

        Console.WriteLine("Valor Presente= R$ " + valorPresente.ToString("F2"));
        Console.WriteLine("Loop a.m.\tTaxa Juros(%)\t Rendimento\t\t\tRenda liquida\t\t\tRenda acumulada");

      

        for (int i = 0; i <= meses; i++)
        {
            double rendaliquida = valorPresente * taxa/100;
            double rendimento = valorPresente + rendaliquida;
            double rendimentoatualizado = rendimento - 3800;

            double rendacumulada = rendimentoatualizado + valorPresente;
            

            Console.WriteLine($"{i}\t\t{taxa:C2}\t\t{rendimento:C2}\t\t\t{rendimentoatualizado:C2}\t\t\t{rendacumulada:C}");

            valorPresente = rendimento;
           
        }
    }
}
