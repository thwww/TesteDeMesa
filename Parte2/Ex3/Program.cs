using System;
using System.Runtime.ConstrainedExecution;

class Program {
    static void Main(string[] args) {

    System.Console.WriteLine("Digite o valor Inicial:");
    double initialValue = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite a taxa de juros:");
    double interestRates = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite o periodo em anos:");
    double year = double.Parse(Console.ReadLine());

    double finalValue = initialValue * Math.Pow(1 + (interestRates / 100), year);

    double performance = finalValue - initialValue;

    System.Console.WriteLine($"Valor Inicial do Investimento: R$ {initialValue:F2}");
    System.Console.WriteLine($"Taxa de juros: {interestRates}%");
    System.Console.WriteLine($"Periodo de tempo: {year} anos");
    System.Console.WriteLine($"Rendimento do investimento: R$ {performance:F2}");
    System.Console.WriteLine($"Valor Final do investimento R$ {finalValue:F2}");
    }
}