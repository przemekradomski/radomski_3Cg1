using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System;

class Pracownik
{
    private decimal wynagrodzenie;
    protected string imie;
    internal string dzial;

    public Pracownik(string imie, string dzial, decimal wynagrodzenie)
    {
        this.imie = imie;
        this.dzial = dzial;

        if(wynagrodzenie > 0)
        {
            this.wynagrodzenie = wynagrodzenie;
        }
        else
        {
            this.wynagrodzenie = 0;
        }


    }

    public void pokazDane()
    {
        Console.WriteLine($"Imie: {imie}");
        Console.WriteLine($"Dzial: {dzial}");
        Console.WriteLine($"Wynagrodzenie: {wynagrodzenie} PLN");
    }

    public void zmienWynagrodzenie(decimal kwota)
    {
        if(kwota > 0)
        {
            wynagrodzenie = kwota;
            Console.WriteLine("Zmieniono wynagrodzenie");
        }
        else
        {
            Console.WriteLine("Wynagrodzenie nie może być mniejsze od zera");
        }
    }

}