//declarăm o variabilă de tipul "ITaxiRide" și se creează un obiect de tipul "TaxiRide" c
//u o distanță de 6 kilometri. Astfel, variabila "ride" va referi obiectul "TaxiRide" creat.
ITaxiRide ride = new TaxiRide(6);
Console.WriteLine($"Pret calatorie simpla taxi: {ride.GetPrice()}");

//creem un obiect de tipul "NightTaxiRide" și îi atribuim variabilei "nightTaxiRide".
//Obiectul "nightTaxiRide" este decorat cu prețul suplimentar pentru călătoriile nocturne.
//Acest obiect ia ca argument obiectul "ride" creat anterior.
ITaxiRide nightTaxiRide = new NightTaxiRide(ride);
Console.WriteLine($"Pret calatorie nocturna: {nightTaxiRide.GetPrice()}");

//creem un obiect de tipul "OutsideCityTaxiRide" și îi atribuim variabilei "outsideCityTaxiRide".
//Acest obiect adaugă un cost suplimentar pentru călătoriile în afara orașului.
//Acest obiect ia ca argument obiectul "nightTaxiRide" creat anterior.
ITaxiRide outsideCityTaxiRide = new OutsideCityTaxiRide(nightTaxiRide);
Console.WriteLine($"Pret calatorie nocturna in afara orasului: {outsideCityTaxiRide.GetPrice()}");
Console.ReadKey();