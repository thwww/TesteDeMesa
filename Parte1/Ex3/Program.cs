using System;
class Exercicio3{

    static void Main(){

        int a = 7;
        int b = a - 6;
        int [] V = new int [14];

        while (b < a){ 

            V[b] = b + a;
            System.Console.WriteLine($"V[{b}] = {V[b]}");
            b+=2;
        }
    }

}