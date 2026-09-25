using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Pojazd
{
    protected string nazwaModelu;

    public Pojazd(string model)
    {
        this.nazwaModelu = model;
    }

    public virtual void Jedz()
    {
        Console.WriteLine($"{nazwaModelu} jedzie");
    }
}

class Samochod : Pojazd
{
    public Samochod(string nazwaModelu) : base(nazwaModelu){}
    public override void Jedz()
    {
        Console.WriteLine($"{nazwaModelu} jedzie po szosie");
    }
}


class Rower : Pojazd
{
    public Rower(string nazwaModelu) : base(nazwaModelu){}
    public override void Jedz()
    {
        Console.WriteLine($"Rowerzysta jedzie na {nazwaModelu}");
    }
}

class Program
{   

    static void Main()
    {
        Pojazd[] pojazdy = new Pojazd[]
        {
            new Pojazd("FSO Polonez"),
            new Rower("Kross"),
            new Samochod("BMW E46")
        };

        foreach(var poj in pojazdy)
        {
            poj.Jedz();
        }
    }

}