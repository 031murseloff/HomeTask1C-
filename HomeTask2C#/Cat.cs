namespace HomeTask2C_;

public class Cat:Animal
{
    public Cat(string nickName, int age, string gender, double energy, int price, int mealQuantity) : 
        base(nickName, age, gender, energy, price, mealQuantity)
    {

    }

    public override void play()
    {
        Console.WriteLine("Cat play");
       Console.WriteLine( $"Cat Energy: {energy -= 20}");
        if(energy <=0 )
        {
            sleep();
        }
    }
    public override void sleep()
    {
        Console.WriteLine("Cat sleep");
        energy += 50;

    }
    public override void eat()
    {
        Console.WriteLine("Cat eat");
        price += 10;
        energy += 10;
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
