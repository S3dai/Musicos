class Musico
{
    public string Nombre{get; set;}

    public Musico(string n)
    {Nombre = n;}

    public void Saluda()
    {
        Console.WriteLine("Hola, soy ");
    }

    public virtual void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }
}

class Bajista
{
    public string Bajo {get; set;}
    
    public Bajista(string n, string b) : base (n)
    {
        Bajo = b;
    }
}
class Program
{
    internal static void Main(string[] args)
    {
        Musico CodyCarson = new Musico();
        CodyCarson.Saluda();
        CodyCarson.Toca();
    }
}