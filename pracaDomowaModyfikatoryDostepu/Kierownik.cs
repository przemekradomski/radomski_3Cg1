class Kierownik : Pracownik
{
    public Kierownik(string imie, string dzial, decimal wynagrodzenie): base(imie, dzial, wynagrodzenie){}
    public void przedstawSie()
    {
        System.Console.WriteLine($"Jestem Kierownikiem, mam na imie {imie}");
    }
}