using System;
class KontoBankowe
{
    private string wlasciciel;
    private double saldo;
    
    public KontoBankowe(string imie, double poczatkoweSaldo)
    {
        wlasciciel = imie;
        saldo = poczatkoweSaldo >= 0 ? poczatkoweSaldo : 0;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public void Wplac(double kwota)
    {
        if(kwota > 0)
        {
            saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota} PLN");
        }
        else
        {
            System.Console.WriteLine("Nieprawidłowa kwota");
        }
    }
}
