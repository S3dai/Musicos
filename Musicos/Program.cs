class Musico
{
    public string Nombre{get; set}

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
class Program
{
    internal static void Main(string[] args)
    {

    }
}