using System;

//definim o interfață IEngine care specifică o metodă GetConsumption() care
//returnează consumul unui motor în litri/100km. Această interfață va fi implementată
//de clasele JZ2 și RB26, care sunt tipurile de motor disponibile pentru modelele de mașini Supra și GTR.
public interface IEngine
{
    double GetConsumption();
}

//definim clasa JZ2, care reprezintă un tip de motor disponibil pentru modelul de mașină Supra.
//Clasa implementează interfața IEngine și suprascrie metoda GetConsumption(),
//returnează consumul specific pentru acest motor.
public class JZ2 : IEngine
{
    public double GetConsumption()
    {
        return 11.6;
    }
}

//definim clasa RB26, care reprezintă un tip de motor disponibil pentru modelul de mașină GTR.
//Clasa implementează interfața IEngine și suprascrie metoda GetConsumption(),
//returnează consumul specific pentru acest motor.
public class RB26 : IEngine
{
    public double GetConsumption()
    {
        return 12.3;
    }
}

//definim clasa abstractă Car, care va fi moștenită de clasele concrete Supra și GTR.
//Clasa definește o variabilă protected _engine de tip IEngine și un constructor care
//primește o instanță de IEngine și o atribuie variabilei _engine.
//Această clasă abstractă definește metoda abstractă DisplayConsumption(), c
//are va fi implementată de clasele de mai jos.
public abstract class Car
{
    protected IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public abstract void DisplayConsumption();
}

//definim clasa Supra, care este un tip de mașină cu un motor de tip JZ2. Această clasă
//moștenește clasa abstractă Car și implementează metoda DisplayConsumption(),
//care afișează consumul specific al mașinii Supra.
public class Supra : Car
{
    public Supra(IEngine engine)
        : base(engine)
    { }

    public override void DisplayConsumption()
    {
        Console.WriteLine("Supra consumption: " + _engine.GetConsumption());
    }
}

//definim clasa GTR, care este un tip de mașină cu un motor de tip RB26. Această clasă
//moștenește clasa abstractă Car și implementează metoda DisplayConsumption(),
//care afișează consumul specific al mașinii GTR.
public class GTR : Car
{
    public GTR(IEngine engine)
        : base(engine)
    { }

    public override void DisplayConsumption()
    {
        Console.WriteLine("GTR consumption: " + _engine.GetConsumption());
    }
}
