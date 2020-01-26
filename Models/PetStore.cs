using System.Collections.Generic;

namespace petStore.Models
{
  class PetStore
  {
    public string Name { get; set; }
    //NOTE creating the list for the dogs to be in the pet store
    public List<Dog> Dogs { get; set; }

    //NOTE this adds a single dog to the Pet Store

    public void AddInventory(Dog dog)
    {
      Dogs.Add(dog);
    }

    //NOTE having the List passed in the parameters allows you to add multiple dogs to the store, this is also method overloading
    public void AddInventory(List<Dog> dog)
    {
      Dogs.AddRange(dog);
    }



    public void PrintDogs()
    {
      for (int i = 0; i < Dogs.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Dogs[i].FirstName} {Dogs[i].Type} {Dogs[i].Legs}");
      }
    }




    public PetStore(string name)
    {
      Name = name;
      Dogs = new List<Dog>();
    }
  }
}