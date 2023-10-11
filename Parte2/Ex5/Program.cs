using System;

class Program {
    static void Main(string[] args) {

        double initialValue = 3800.00;
        double monthlyInterest = 1.25 / 100;
        double futureValue = 7390.61;

        double requiredValue = (futureValue - initialValue);

        double numberOfMonths = Math.Log(futureValue / initialValue) / Math.Log(1 + monthlyInterest);
        int monthsRequired = (int)Math.Ceiling(numberOfMonths);

        System.Console.WriteLine($"Valor inicial do investimento: R$ {initialValue:C2}");
        System.Console.WriteLine($"Taxa de juros mensal: {monthlyInterest * 100}%");
        System.Console.WriteLine($"Valor futuro desejado: R$ {futureValue:C2}");
        System.Console.WriteLine($"Período de tempo em meses necessarios para o objetivo: {monthsRequired} meses");
        System.Console.WriteLine($"Valor necessário para atingir o valor futuro desejado: R$ {requiredValue:C2}");
    }
}