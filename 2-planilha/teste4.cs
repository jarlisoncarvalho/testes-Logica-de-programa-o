using System;

class Program
{
    static void Main(string[] args)
    {
        double valorinicial;
        double[] rendimentos;
        double taxajuros;
        int periodo;


        Console.Write("Informe o valor inicial do investimento:");
        valorinicial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a taxa de juros:");
        taxajuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o periodo:");
        periodo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Valor inicial do investimento: R$ {valorinicial:C2}\t");
        double aux = valorinicial;

        rendimentos = new double[periodo + 1];

        for (int i = 0; i <= periodo; i++)
        {
            rendimentos[i] = valorinicial *= (1 + taxajuros / 100);
            double rendaLiquida = rendimentos[i] - aux;
            Console.WriteLine($"Mês {i}: Rendimento: R$ {valorinicial:F2} | Renda Líquida: R$ {rendaLiquida:F2}");
            valorinicial = rendimentos[i];
        }

        Console.Write("\nDeseja realizar um saque no mes 5? (s/n): ");
        string resposta = Console.ReadLine();

        if (resposta.ToLower() == "s")
        {
            Console.Write("Informe o valor do saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());

            valorinicial -= valorSaque;
            rendimentos[5] -= valorSaque;

            double rendMespossaque = rendimentos[4] - valorSaque;

            Console.WriteLine($" Saldo restante mês 5 após o saque: R$ {rendMespossaque:F2}");
            Console.WriteLine($"\nValor atual do investimento após o saque: {valorinicial:C2}");
           

        }
    }
}
