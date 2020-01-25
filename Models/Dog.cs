namespace petStore.Models

{
  class Dog
  {
    //NOTE These are the properties within the Dog Model. Get is set to public so individuals can access the information, set is private so they cannot set the value and change it.
    public string FirstName { get; private set; }
    public string Type { get; private set; }
    public int Legs { get; private set; }
    public bool Tail { get; private set; }
    public bool Happy { get; private set; }
    public int Tolerance { get; private set; }
    //NOTE Needed to add a property for Pets
    private int Pets { get; set; }

    //NOTE Method for getting the dog details

    public string DogDetails()
    {
      return $@"
      Name: {FirstName}
      Type: {Type}
      Legs: {Legs}
      Tolerance: {Tolerance}
      ";
    }

    //NOTE public void will not return anything, if you want it to return something than you declare the type string, int etc than down in your function you than will have to return instead of cw.
    public void PuppyPets()
    {
      Pets++;
      Happy = Pets < Tolerance;
      if (Happy)
      {
        System.Console.WriteLine("I am in such a good mood!");
      }
      else
      {
        System.Console.WriteLine("Why are you petting me so much?");
      }
    }


    //NOTE Created a Dog constructor taking in all the parameters with no default set
    public Dog(string firstName, string type, int legs, int tolerance)
    {
      FirstName = firstName;
      Type = type;
      Legs = legs;
      Tail = true;
      Happy = true;
      Tolerance = tolerance;
    }
  }
}