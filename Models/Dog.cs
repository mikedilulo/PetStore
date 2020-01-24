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