using System;

class Program {
    static void Main(string[] args) {

        double initialValue = 1000.00;

        double interestRates = 5.30;

        int period = 6;

        double finalValue = initialValue * Math.Pow(1 + (interestRates / 100), period);

        double performance = finalValue - initialValue;

        System.Console.WriteLine($"Valor Inicial do Investimento: R$ {initialValue:C2}");
        System.Console.WriteLine($"Taxa de juros: {interestRates}%");
        System.Console.WriteLine($"Periodo de tempo: {period} meses");
        System.Console.WriteLine($"Rendimento do investimento: R$ {performance:C2}");
        System.Console.WriteLine($"Valor Final do investimento R$ {finalValue:C2}");
        
    }
}