using System;

namespace Domain
{
  public class SomeClass
  {
    public const string SomeText = "some text";

    public string SomeProperty { get; }

    public SomeClass(string someProperty) => SomeProperty = someProperty;

    //The below is probably a code smell.
    public string SomeMethod() => "SomeMethod";

    public void DoSomethingMeaningful()
    {
      for (var i = 0; i < 1000; i++)
      {
        Console.WriteLine(i);
      }
    }

  }
}
