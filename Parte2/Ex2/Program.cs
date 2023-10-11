using System;

class Program {
    static void Main(string[] args) {

        double initialValue = 3800.00;
        double monthlyInterestRate = 1.25 / 100;
        int month = 6;

        double finalValue = initialValue * Math.Pow(1 + monthlyInterestRate, month);

        double totalIncome = finalValue - initialValue;

        System.Console.WriteLine($"Valor inicial do investimento: R$ {initialValue:C2}");
        System.Console.WriteLine($"Taxa de juros mensal: {monthlyInterestRate * 100}%");
        System.Console.WriteLine($"Periodo de tempo: {month} meses");
        System.Console.WriteLine($"Valor final do Investimento: R$ {finalValue:C2}");
        System.Console.WriteLine($"Rendimento total do Investimento: R$ {totalIncome:C2}");

        double currentValue = initialValue;
        System.Console.WriteLine("\nApresentacao do rendimento mensal:");
        for (int m = 1; m <= month; m++) {
            double monthlyIncome = currentValue * monthlyInterestRate;
            currentValue += monthlyIncome;
            System.Console.WriteLine($"Mes {m}: Rendimento por mes R$ {monthlyIncome:C2} / Valor Final a cada mes: R$ {currentValue:C2}");

        }
    }
}