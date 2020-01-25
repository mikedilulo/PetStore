using System;
using petStore.Models;

namespace petStore
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my PetStore!");
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
    }
  }
}
