using System.Security.Cryptography.X509Certificates;

class Car
{
    public string brnad {get; set;}
    public string color {get; set;}
    public int year {get; set;}
    public float lenght {get; set;}


    public void displayInfo()
    {
        System.Console.WriteLine($"Samochód {brnad}, rocznik: {year}, kolor {color}");
    }
}