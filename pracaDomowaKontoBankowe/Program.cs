
using System;

class KontoBankowe
{
    public string Wlasciciel { get; private set; }
    public decimal Saldo { get; private set; }

    public KontoBankowe(string wlasciciel, decimal saldo)
    {
        Wlasciciel = wlasciciel;
        Saldo = Math.Max(0, saldo);
    }

    public void Wplac(decimal kwota)
    {
        if (kwota <= 0)
            Console.WriteLine("Nieprawidłowa kwota!");
        else
            Saldo += kwota;
    }

    public void Wyplac(decimal kwota)
    {
        if (!CzyStacMnie(kwota))
            Console.WriteLine("Brak środków!");
        else
            Saldo -= kwota;
    }

    public bool CzyStacMnie(decimal kwota)
    {
        return kwota > 0 && Saldo >= kwota;
    }

    public void Przelew(KontoBankowe odbiorca, decimal kwota)
    {
        if (odbiorca == null || odbiorca == this ||
            !CzyStacMnie(kwota))
        {
            Console.WriteLine("Przelew odrzucony!");
            return;
        }

        Saldo -= kwota;
        odbiorca.Saldo += kwota;
        Console.WriteLine("Przelew wykonany!");
    }

    public void PokazInformacje()
    {
        Console.WriteLine(
            $"Właściciel: {Wlasciciel} | Aktualne saldo: {Saldo} zł");
    }
}

class Program
{
    static decimal Kwota(string tekst)
    {
        decimal kwota;
        Console.Write(tekst);

        while (!decimal.TryParse(Console.ReadLine(), out kwota))
            Console.Write("Błędna liczba, spróbuj ponownie: ");

        return kwota;
    }

    static void Main()
    {
        KontoBankowe[] konta = new KontoBankowe[3];

        for (int i = 0; i < konta.Length; i++)
        {
            Console.Write($"Imię właściciela {i + 1}: ");
            string imie = Console.ReadLine() ?? "";

            decimal saldo = Kwota("Saldo początkowe: ");
            while (saldo < 0)
                saldo = Kwota("Saldo nie może być ujemne. Podaj ponownie: ");

            konta[i] = new KontoBankowe(imie, saldo);
        }

        string wybor;

        do
        {
            Console.WriteLine(
                "\n1. Salda  2. Wpłata  3. Wypłata  4. Czy stać mnie?  5. Przelew  0. Koniec");
            Console.Write("Wybierz: ");
            wybor = Console.ReadLine() ?? "";

            if (wybor == "1")
                foreach (var konto in konta)
                    konto.PokazInformacje();

            else if (wybor == "2" || wybor == "3" || wybor == "4")
            {
                int nr = (int)Kwota("Numer konta (1-3): ") - 1;

                if (nr < 0 || nr >= konta.Length)
                {
                    Console.WriteLine("Nieprawidłowe konto!");
                    continue;
                }

                decimal kwota = Kwota("Kwota: ");

                if (wybor == "2")
                    konta[nr].Wplac(kwota);
                else if (wybor == "3")
                    konta[nr].Wyplac(kwota);
                else
                    Console.WriteLine(konta[nr].CzyStacMnie(kwota));
            }
            else if (wybor == "5")
            {
                int od = (int)Kwota("Konto nadawcy (1-3): ") - 1;
                int doKonta = (int)Kwota("Konto odbiorcy (1-3): ") - 1;

                if (od < 0 || od >= 3 || doKonta < 0 || doKonta >= 3)
                {
                    Console.WriteLine("Nieprawidłowe konto!");
                    continue;
                }

                konta[od].Przelew(konta[doKonta], Kwota("Kwota przelewu: "));
            }

        } while (wybor != "0");
    }
}
