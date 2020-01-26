using System;
using petStore.Models;

namespace petStore
{
  class Program
  {
    static void Main(string[] args)
    {
      PetStore myPetStore = new PetStore("Mikes PetStore");
      Console.WriteLine($"Welcome to {myPetStore.Name}!");
      Dog maya = new Dog("Maya", "Husky", 4, 5);
      Dog lola = new Dog("Lola", "Pitbull", 4, 7);
      Console.WriteLine(maya.DogDetails());
      Console.WriteLine(lola.DogDetails());
      maya.PuppyPets();
      maya.PuppyPets();
      maya.PuppyPets();
      maya.PuppyPets();
      maya.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();
      lola.PuppyPets();

      PetStore p = new PetStore("Mike's PetStore");
      {
        p.AddInventory(maya);
        p.AddInventory(lola);
      }
      myPetStore.PrintDogs();
    }
  }
}
