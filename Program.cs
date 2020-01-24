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
      Console.WriteLine(maya.DogDetails());
    }
  }
}
