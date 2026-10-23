class Pojazd
{
    protected string model = "Nieznany";
    protected int rokProdukcji = 0;

    public Pojazd(string model, int rokProdukcji)
    {
        this.model = model;
        this.rokProdukcji = rokProdukcji;
    }

    public Pojazd(string Model)
    {
        this.model = Model;
        this.rokProdukcji = rokProdukcji;
    }
    
}

