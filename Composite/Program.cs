using System;
using System.Collections.Generic;

interface IShape
{
    void Draw();
}

//Clasele Square și Circle definesc implementările lor specifice pentru metoda Draw(),
//care afișează un mesaj de consolă care indică ce formă geometrică este desenată.
class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Desenam un patrat.");
    }
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Desenam un cerc.");
    }
}

//Clasa Group reprezintă un grup de forme geometrice, iar constructorul său inițializează
//o listă de forme geometrice goale. Apoi, clasa are o metodă Add() pentru a adăuga
//forme geometrice individuale la lista sa. Metoda Draw() iterază prin lista de forme geometrice
//și afișează mesajul de consolă corespunzător pentru fiecare formă geometrică în parte.
class Group : IShape
{
    private List<IShape> _shapes = new List<IShape>();

    public void Add(IShape shape)
    {
        _shapes.Add(shape);
    }

    public void Draw()
    {
        Console.WriteLine("Desenam un grup de forme:");
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }
}
