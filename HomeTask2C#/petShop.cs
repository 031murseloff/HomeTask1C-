namespace HomeTask2C_;

public class petShop
{
    List<Animal> animals = new List<Animal>();

   public void Add(Animal animal)
    {
      animals.Add(animal);
    }

    public void RemoveforNickName(string nickname) {

        foreach (Animal animal in animals)
        {
            if(animal.nickName == nickname)
            {
                animals.Remove(animal);
            }
        }

    }
  
    

}
