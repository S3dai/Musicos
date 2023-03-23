abstract class Musico
{
    public string Nombre{get; set;}

    public Musico(string n)
    {Nombre = n;}

    public void Saluda()
    {
        Console.WriteLine("Hola, soy ");
    }

    public /*virtual*/ abstract void Toca();
    /*{
        Console.WriteLine($"{Nombre} tocando su instrumento");
    }*/
}

class Bajista : Musico
{
    public string Bajo {get; set;}

    public Bajista(string n, string b) : base (n)
    {
        Bajo = b;
    }

    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {Bajo}");
    }
}

class Program
{
    internal static void Main(string[] args)
    {
        Musico Artista = new Musico("Cody Carson");
        Artista.Saluda();
        Artista.Toca();

        List<Musico> SetitOff = new List<Musico>();
        SetitOff.Add(new Bajista("Zach DeWall", "Fender"));

        foreach (var m in SetitOff)
        m.Saluda();

        foreach (var m in SetitOff)
        m.Toca();
    }
}