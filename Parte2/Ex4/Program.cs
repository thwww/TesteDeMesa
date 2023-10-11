using System;

class Program {
    static void Main(string[] args) {
        double initialValue = 2000;
        double interestRate = 0.02;
        double annualInterest = 0.005;
        double balance = initialValue;
        int period = 6;

        System.Console.WriteLine("|  Mês  | Saldo Inicial |  Rendimento  |  Juros  |    Saque    | Saldo Final |");
        System.Console.WriteLine("|-------|---------------|--------------|---------|-------------|-------------|");

        for (int month = 1; month <= 6; month++) {
            double fees = balance * interestRate; 
            double income = annualInterest * Math.Pow(1 + interestRate, period);
            double withdraw = 0;
            
            if (month == 5) {
                withdraw = 1000;
            }

            balance += fees + income - withdraw;

            System.Console.WriteLine($"| {month,5} | {initialValue,-13:C2} | {fees,12:C2} | {interestRate * 100,-6}% | {withdraw,-11:C2} | {balance,-11:C2} |");
        }
    }
}