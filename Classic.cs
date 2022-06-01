namespace ConsoleApp1;

public class Classic : Сocktail
{
    public Classic()
    {
        prepare();
    }

    public override void addIceCream()
    {
        Console.WriteLine("Add cream");
    }


    public override void addToping()
    {
        
    }

    public override bool custumerWontsToping()
    {
        return false;
    }
}