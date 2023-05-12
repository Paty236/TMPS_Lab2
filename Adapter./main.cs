// creem o instanță a clasei Adaptee folosind constructorul implicit
var adaptee = new Adaptee();

//creem o instanță a clasei Adapter, care este obiectul cheie al design pattern-ului Adapter. 
var adapter = new Adapter(adaptee);

//afișăm data și ora curente prin apelarea metodei GetFullDate() a obiectului Adapter
//și concatenarea rezultatului cu șirul de caractere "Current date and time: ".
//Metoda GetFullDate() este implementată pentru a returna data și ora curente,
//convertite într-un șir de caractere, prin intermediul obiectului Adaptee.
Console.WriteLine("Current date and time: " + adapter.GetFullDate());
Console.ReadKey();