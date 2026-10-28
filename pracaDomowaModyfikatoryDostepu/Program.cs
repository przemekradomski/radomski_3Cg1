class Program
{
    static void Main()
    {
        Pracownik pracownik = new Pracownik("Przemek", "IT", 5000m);
        Kierownik kierownik = new Kierownik("Szymon", "Sprzedaż", 10000m);

        Console.WriteLine("Pracownik");
        pracownik.pokazDane();

        Console.WriteLine("Kierownik");
        kierownik.pokazDane();
        kierownik.przedstawSie();

        Console.WriteLine("Zmiana wynagrodzenia");
        pracownik.zmienWynagrodzenie(6000m);
        pracownik.pokazDane();

        Console.WriteLine("Sprawdzenie pola dział");
        Console.WriteLine($"Dział pracownika {pracownik.dzial}");

    }
}