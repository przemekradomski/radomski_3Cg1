class Program
{
    public static void Main(string[]args)
    {
        // KontoBankowe konto = new KontoBankowe("Przemek Radomski", 10000.00);
        // konto.Wplac(500);
        // Console.WriteLine($"Aktualne saldo to: {konto.GetSaldo()} PLN");

        Student student = new Student("Przemek", "Radomski", "3c", 17);
        Console.WriteLine($"Imie: {student.GetFirstName()}, nazwisko {student.GetLastName()}, wiek: {student.getAge()}, klasa: {student.getGroup()}");
    }
}
