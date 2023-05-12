using System;

//definim o interfata ITaxiRide, care contine doua metode abstracte: GetPrice si GetDistance.
//Aceasta va fi implementata de clasa TaxiRide si de altelecare o vor extindeprin intermediul Decorator.
public interface ITaxiRide
{
    double GetPrice();
    double GetDistance();
}

//definim clasa TaxiRide, care implementeaza interfata ITaxiRide. Clasa are doua constante BookingPrice
//si PricePerKm, care sunt folosite pentru a calcula pretul unei curse. Constructorul primeste distanta
//ca parametru si verifica daca aceasta este pozitiva, apoi o salveaza intr-un camp privat.
//Metoda GetPrice calculeaza si returneaza pretul cursei, iar metoda GetDistance returneaza distanta parcursa.
public class TaxiRide : ITaxiRide
{
    private const double BookingPrice = 15.0;
    private const double PricePerKm = 2.3;

    private readonly double _distance;

    public TaxiRide(double distance)
    {
        if (distance > 0)
            _distance = distance;
    }

    public double GetPrice()
    {
        return BookingPrice + PricePerKm * _distance;
    }

    public double GetDistance()
    {
        return _distance;
    }
}

//definim clasa abstracta TaxiRideDecorator, care extinde interfata ITaxiRide si are un camp
//privat de tip ITaxiRide. Constructorul primeste ca parametru un obiect de tip ITaxiRide
//si il salveaza in campul privat. Clasa contine doua metode virtuale: GetPrice si GetDistance,
//care sunt implementate pentru a returna valorile corespunzatoare obiectului ITaxiRide dat ca parametru.
public abstract class TaxiRideDecorator : ITaxiRide
{
    protected ITaxiRide _ride;

    protected TaxiRideDecorator(ITaxiRide ride)
    {
        _ride = ride;
    }

    public virtual double GetPrice()
    {
        return _ride.GetPrice();
    }

    public virtual double GetDistance()
    {
        return _ride.GetDistance();
    }
}

//definim clasa NightTaxiRide, care extinde clasa TaxiRideDecorator. Clasa are o constanta NightAddition
//si o metoda privata CalculateAddition, care calculeaza adaugarea de pret pentru o cursa de noapte, in
//functie de distanta parcursa. Constructorul primeste un obiect de tip ITaxiRide si il transmite constructor
public class NightTaxiRide : TaxiRideDecorator
{
    private const double NightAddition = 1.2;

    public NightTaxiRide(ITaxiRide ride)
        : base(ride)
    {
    }

    public override double GetPrice()
    {
        return _ride.GetPrice() + CalculateAddition();
    }

    private double CalculateAddition()
    {
        return _ride.GetDistance() * NightAddition;
    }
}

//definim clasa OutsideCityTaxiRide, care extinde clasa TaxiRideDecorator. Clasa are o constanta OutsideCityAddition
//si o metoda privata CalculateAddition, care calculeaza adaugarea de pret pentru o cursa in afara orasului, in
//functie de distanta parcursa. Constructorul primeste un obiect de tip ITaxiRide si il transmite constructor
public class OutsideCityTaxiRide : TaxiRideDecorator
{
    private const double OutsideCityAddition = 0.8;

    public OutsideCityTaxiRide(ITaxiRide ride)
        : base(ride)
    {
    }

    public override double GetPrice()
    {
        return _ride.GetPrice() + CalculateAddition();
    }

    private double CalculateAddition()
    {
        return _ride.GetDistance() * OutsideCityAddition;
    }
}
