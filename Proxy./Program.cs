using System;
using System.IO;

//definim interfeța ILogger, care specifică o metodă LogThis ce primește două argumente:
//un text care trebuie logat și un nivel pentru logare
interface ILogger
{
    void LogThis(string text, int level);
}

//Clasa RealLogger implementează interfața ILogger și este pentru scrierea log-urilor în fișier.
//Aceasta primește calea către fișierul de logare în constructor și, în metoda LogThis,
//afișează un mesaj pe consolă, și scrie textul de logare în fișier folosind clasa StreamWriter.
class RealLogger : ILogger
{
    private readonly string _filePath;

    public RealLogger(string filePath)
    {
        _filePath = filePath;
    }

    public void LogThis(string text, int level)
    {
        Console.WriteLine($"Writing into {_filePath} the following:");
        Console.WriteLine($"\tLevel {level}: {text}");
        using StreamWriter writer = new StreamWriter(_filePath, true);
        writer.WriteLine($"Level {level}: {text}");
    }
}

//Clasa ProxyLogger este o implementare a design pattern-ului Proxy, care implementează interfața ILogger.
//Aceasta primește calea către fișierul de logare în constructor și declară o instanță a clasei RealLogger.
//Metoda LogThis a clasei ProxyLogger verifică nivelul de logare și, dacă este mai mare sau egal cu o anumită
//valoare minimă (minLevel), atunci apelul metodei LogThis este către instanța de RealLogger,care se ocupă
//de scrierea efectivă a log-ului. Dacă nivelul este prea mic, metoda LogThis a clasei ProxyLogger nu face nimic.
class ProxyLogger : ILogger
{
    private readonly RealLogger _realLogger;
    private const int minLevel = 5;

    public ProxyLogger(string filePath)
    {
        _realLogger = new RealLogger(filePath);
    }

    public void LogThis(string text, int level)
    {
        if (level >= minLevel)
            _realLogger.LogThis(text, level);
    }
}
