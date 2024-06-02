namespace HomeTask2C_;

public class Bird : Animal
{

    public Bird(string nickName, int age, string gender, double energy, int price, int mealQuantity) : base(nickName, age, gender, energy, price, mealQuantity)
    {

    }

    public override void eat()
    {
        Console.WriteLine("Bird eat");
        price += 10;
        energy += 10;
    }

    public override void play()
    {
        Console.WriteLine("Bird play");
        Console.WriteLine($"Bird Energy: {energy -= 20}");
        if (energy <= 0)
        {
            sleep();
        }

    }

    public override void sleep()
    {
        Console.WriteLine("Bird sleep");
        energy += 50;

    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
