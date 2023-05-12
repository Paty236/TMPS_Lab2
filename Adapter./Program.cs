using System;
//Clasa reprezintă o componentă existentă (Adaptee) pe care vrem să o a
//daptăm într-o altă interfață utilizând un design pattern de tip Adapter.
//Clasa Adaptee are o singură metodă, GetCurrentTimeAndDate(),
//care returnează data și ora curente ca un șir de caractere.
public class Adaptee
{
    public Adaptee() { }

    public string GetCurrentTimeAndDate()
    {
        var currentTime = DateTime.Now;
        return currentTime.ToString();
    }
}

//Clasa reprezintă interfața țintă (Target) care trebuie să fie adaptată.
//Aceasta este o clasă abstractă care conține o referință către Adaptee și
//o metodă abstractă GetFullDate() pe care clasa Adapter va trebui să o implementeze.
public abstract class Target
{
    protected Adaptee _adaptee;

    public Target(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public abstract string GetFullDate();
}

//Clasa reprezintă Adapterul. Aceasta moștenește din clasa Target și implementează
//metoda abstractă GetFullDate() prin apelarea metodei GetCurrentTimeAndDate() a
//obiectului Adaptee pentru a obține data și ora curente sub forma unui șir de caractere.
//Astfel este posibilă utilizarea clasei Adaptee într-un context care necesită interfața
//specificată de clasa Target.
public class Adapter : Target
{
    public Adapter(Adaptee adaptee)
        : base(adaptee)
    { }

    public override string GetFullDate()
    {
        return _adaptee.GetCurrentTimeAndDate();
    }
}
