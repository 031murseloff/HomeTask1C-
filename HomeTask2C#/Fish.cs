namespace HomeTask2C_;

public class Fish : Animal
{
    public Fish(string nickName, int age, string gender, double energy, int price, int mealQuantity) : base(nickName, age, gender, energy, price, mealQuantity)
    {

    }

    public override void eat()
    {
       Console.WriteLine("fish eat");
        price += 10;
        energy += 10;
    }

    public override void play()
    {
        Console.WriteLine("fish play");
       
        Console.WriteLine($"fish Energy: {energy -= 20}");
        if (energy <= 0)
        {
            sleep();
        }
    }

    public override void sleep()
    {
        Console.WriteLine("fish sleep");
        
        energy += 50;
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
