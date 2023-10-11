using System;
class Exercicio2{

    static void Main(){

        int a = 2;
        int [] V = new int [6];

        while(a < 6){
            V[a] = 10 * a;
            System.Console.Write($"V[a] = {V[a]}");
            a++;

            System.Console.WriteLine($"| Contador: {a}");
        }
           
    }

}