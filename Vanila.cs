namespace ConsoleApp1;

public class Vanilla : Сocktail
{
    public Vanilla()
    {
        prepare();
    }

    public override void addIceCream()
    {
        Console.WriteLine("add Vanilla ice cream");
    }

    public override void addToping()
    {
        Console.WriteLine("add vanilla toping");
    }
}