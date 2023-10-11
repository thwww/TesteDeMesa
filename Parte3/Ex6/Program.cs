using System;

class Program {
    static void Main(string[] args) {

        System.Console.Write("Digite o valor inicial: ");
        double initialValue = double.Parse(Console.ReadLine());

        System.Console.Write("Digite a taxa de juros (em % ao mês): ");
        double interestRate = double.Parse(Console.ReadLine()) / 100;

        int nDay = 8 * 30 + 10;
        double performance = CalcularRendimento(initialValue, interestRate, nDay);

        System.Console.WriteLine("Tabela de rendimento para 8 meses e 10 dias:");
        System.Console.WriteLine("Mês| Rendimento");
        System.Console.WriteLine("---|-----------------------");
        for (int i = 1; i <= 8; i++) {
            Console.WriteLine($"{i}  | {CalcularRendimento(initialValue, interestRate, i * 30):C2}");
        }
        double dailyIncome = initialValue * Math.Pow(1 + interestRate, nDay / 30.0) - initialValue;
        System.Console.WriteLine($"Rendimento com mais 10 dias sao: {dailyIncome:C2}");
        System.Console.WriteLine($"Rendimento futuro após 8 meses e 10 dias: {initialValue + performance:C2}");

    }

    static double CalcularRendimento(double initialValue, double interestRate, int nDay) {
        double performance = initialValue * Math.Pow(1 + interestRate, nDay / 30.0) - initialValue;
        return performance;
    }
}