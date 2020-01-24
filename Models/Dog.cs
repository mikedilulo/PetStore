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

    //NOTE Created a Dog constructor taking in all the parameters with no default set

    public Dog(string firstName, string type, int legs, bool tail, bool happy, int tolerance)
    {
      FirstName = firstName;
      Type = type;
      Legs = legs;
      Tail = tail;
      Happy = happy;
      Tolerance = tolerance;

    }
  }
}