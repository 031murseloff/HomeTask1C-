namespace HomeTask2C_;

public class Dog : Animal
{
    public Dog(string nickName, int age, string gender, double energy, int price, int mealQuantity) : base(nickName, age, gender, energy, price, mealQuantity)
    {
    }

    public override void eat()
    {
        Console.WriteLine("Dog eat");
        price += 10;
        energy += 10;
    }

    public override void play()
    {
        Console.WriteLine("dog play");
        Console.WriteLine($"Dog Energy: {energy -= 20}");
        if (energy <= 0)
        {
            sleep();
        }
    }

    public override void sleep()
    {
        Console.WriteLine("Dog sleep");
        energy += 50;
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
