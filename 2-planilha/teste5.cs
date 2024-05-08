using System;

double valorfuturo = 7390.61;

Console.Write("Determine a taxa de juros: ");
double taxa = double.Parse(Console.ReadLine());

Console.Write("Determine o periodo: ");
int Mes = int.Parse(Console.ReadLine());

double presente = valorfuturo / Math.Pow((taxa / 100) + 1, Mes);
Console.WriteLine("Valor presente: " + Math.Round(presente,2));