namespace HomeTask2C_;

public class Animal
{


    public string nickName { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
    public double energy { get; set; }
    public int price { get; set; }
    public int mealQuantity { get; set; }

    public Animal(string nickName, int age, string gender, double energy, int price, int mealQuantity)
    {
        this.nickName = nickName;
        this.age = age;
        this.gender = gender;
        this.energy = energy;
        this.price = price;
        this.mealQuantity = mealQuantity;
    }


    public virtual void play()
    {
        Console.WriteLine("Animal play"); 
    }

    public virtual void sleep()
    {
        Console.WriteLine("Animal sleep"); 
    }

    public virtual void eat()
    {
        Console.WriteLine("Animal eat"); 
    }

    public override string? ToString()
    {
        return $" NickName: {nickName}\n Age:{age}\n Gender: {gender}\n Energy: {energy} \n Price: {price}\n MealQuality: {mealQuantity}\n";
    }
}
