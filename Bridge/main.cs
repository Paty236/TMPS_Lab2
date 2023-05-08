using System;

//Acest program creează instanțe ale claselor JZ2 și RB26 care implementează interfața IEngine,
//apoi creează instanțe ale claselor Supra și GTR care extind clasa abstractă Car.
//Se apelează metoda DisplayConsumption() pentru fiecare instanță de Supra și GTR,
//și afișează consumul fiecărui motor.
class Program
{
    static void Main(string[] args)
    {
        JZ2 jz2 = new JZ2();
        RB26 rb26 = new RB26();
        Supra supra1 = new Supra(jz2);
        Supra supra2 = new Supra(rb26);
        GTR gtr1 = new GTR(rb26);
        GTR gtr2 = new GTR(jz2);

        supra1.DisplayConsumption();
        supra2.DisplayConsumption();
        gtr1.DisplayConsumption();
        gtr2.DisplayConsumption();

        Console.ReadLine();
    }
}
