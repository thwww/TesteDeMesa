using System;
class Exercicio01{

    static void Main(){

        int a = 10;
        int b = 20;
        int c = (a + b)/2;
        int [] V = new int [6];

        c = c - 40;
        V[3] = a+b+c;
        System.Console.Write(V[3]);
        
    }

}