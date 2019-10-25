using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

/* Guid Struct ::: Represent a globally unique identifier (GUID)
 * The following example uses the System.Runtime.intropServices.GuidAttribute class to assign a GUID to an interface and to a
 * user-defined class .
 *
 *
 */
namespace ConsoleApp160
{
  [Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4")]
  interface IMyInterface
  {
    void MyMehod();
  }

  [Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8")]
  public class MyTestClass : IMyInterface
  {

    public static void Main(string[] args)
    {
      GuidAttribute imAttribute =
        (GuidAttribute) Attribute.GetCustomAttribute(typeof(IMyInterface), typeof(GuidAttribute));

      System.Console.WriteLine("IMYintergface atribiute :: " + imAttribute.Value);
      Guid guid1 = new Guid(imAttribute.Value);
      Guid guid2 = new Guid(guid1.ToByteArray());

      if (guid1.Equals(guid2))
        System.Console.WriteLine("myGuid1 equals myGuid2");
      else
        System.Console.WriteLine("myGuid1 does not equal myGuid2");

      // Equality operator can also be used to determine if two guids have same value.
      if (guid1 == guid2)
        System.Console.WriteLine("myGuid1 == myGuid2");
      else
        System.Console.WriteLine("myGuid1 != myGuid2");
    }

    public void MyMehod()
    {
      Console.WriteLine("Hello Harshal Raverkar");
    }
  }

}
