namespace ConsoleApp1;

public class Chocolate : Сocktail
{
    public Chocolate()
    {
        prepare();
    }

    public override void addIceCream()
    {
        Console.WriteLine("add chocolate ice cream");
    }

    public override void addToping()
    {
        Console.WriteLine("add chocolate toping");
    }
}