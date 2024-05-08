using System;

class Investimento
{
    private double valorInvestimento;
    public double taxa;
    private double[] rendimentos;

    public Investimento(double valorInvestimento, double taxa, int meses)
    {
        this.valorInvestimento = valorInvestimento;
        this.taxa = taxa/100;
        rendimentos = new double[meses];
        CalcularRendimentos(meses);
    }

    private void CalcularRendimentos(int meses)
    {
        for (int i = 0; i < meses; i++)
        {

            double rendimentoMensal = valorInvestimento * taxa;
            rendimentos[i] = rendimentoMensal;
            valorInvestimento += rendimentoMensal;
        }
    }

    public void MostrarRendimentos()
    {
        Console.WriteLine("  │ ================================================================│ ");
        Console.WriteLine("  │                      Rendimentos do Investimento                │ ");
        Console.WriteLine("  │ ================================================================│ ");
        Console.WriteLine($" │Valor do investimento: {valorInvestimento:C}                     │ ");
        Console.WriteLine("  │ ================================================================│ ");
        Console.WriteLine($" │ Taxa de rendimento mensal: {taxa}%                           │ ");
        Console.WriteLine("  │ ================================================================│ ");
        Console.WriteLine($"  Período em meses: {rendimentos.Length}                           │ ");
        Console.WriteLine("  │ ================================================================│ ");
        Console.WriteLine("  │                    Rendimento Mês (R$)                          │ ");
        Console.WriteLine("  │ ================================================================│");

        for (int i = 0; i < rendimentos.Length; i++)
        {
            Console.WriteLine($" │   {i + 1,-4} │ {rendimentos[i],51:N2}  │ ");
        }

        Console.WriteLine("╚====================================================================╝");
    }

    public void SacarRendimentoMes5(double valorSaque)
    {
        if (valorSaque <= rendimentos[4]) 
        {
            rendimentos[4] -= valorSaque;
            Console.WriteLine(" │ ============================================================ │");
            Console.WriteLine($"│ Valor do rendimento do mês 5 após o saque: {rendimentos[4]:C}│ ");
            Console.WriteLine(" │ =============================================================│ ");
        }
        else
        {
            Console.WriteLine("Valor de saque inválido. O valor do saque não pode ser maior que o rendimento do mês 5.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor do investimento: ");
        double valorInvestimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da taxa: ");
        double taxa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a quantidade de meses\n: ");
        int meses = Convert.ToInt32(Console.ReadLine());

        Investimento investimento = new Investimento(valorInvestimento, taxa, meses);
        investimento.MostrarRendimentos();

       
            Console.Write("Deseja realizar um saque no mês 5 (s/n)? ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s" || resposta.ToLower() == "sim")
            {
                Console.Write("Informe o valor do saque: ");
                double saque = Convert.ToDouble(Console.ReadLine());
                investimento.SacarRendimentoMes5(saque);
            }
        
    }
}
