namespace ConsoleApp1;

public abstract class Сocktail
{
    protected void prepare()
    {
        addMilk();
        addIceCream();
        pourInGlass();
        if (custumerWontsToping())
        {
            addToping();
        }
    }

    void addMilk()
    {
        Console.WriteLine("Add milk");
    }

    public abstract void addIceCream();

    void pourInGlass()
    {
        Console.WriteLine("Pour in a glass");
    }

    public abstract void addToping();

    public virtual bool custumerWontsToping()
    {
        return true;
    }
}