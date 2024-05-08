using System;

class program1
{
    static void Main(string[] jasd)
    {
        const int meses = 8;
        const int dias = 10;
        double valoresdeinvestimentos, valorestaxa, valorfinal;

        Console.Write("informe o valor do investimento:");
        valoresdeinvestimentos = Convert.ToDouble(Console.ReadLine());

        Console.Write("informe o valor da referente a taxa:");
        valorestaxa = Convert.ToDouble(Console.ReadLine());

        DateTime dataAtual = DateTime.Now;
        DateTime dataFutura = dataAtual.AddMonths(meses).AddDays(dias);
        int totalDias = (int)(dataFutura - dataAtual).TotalDays;

        valorfinal = valoresdeinvestimentos * Math.Pow(1 + valorestaxa / 100, meses + dias / 30.0);
        Console.WriteLine($"valor do investimento:{valorfinal:C2}");

        double valorInvestido = valoresdeinvestimentos;
        for (int i = 1; i <= meses; i++)
        {
            double rendimentoMes = valorInvestido * valorestaxa / 100;
            Console.WriteLine($"Rendimento no mês {i}: {rendimentoMes:C2}");
            valorInvestido += rendimentoMes;
        }
        if (dias > 0)
        {
            double rendimentoDiasAdicionais = valorInvestido * valorestaxa / 100 * dias / 30.0;
            Console.WriteLine($"Rendimento proporcional aos dias adicionais: {rendimentoDiasAdicionais:C}");
        }
    }
}
