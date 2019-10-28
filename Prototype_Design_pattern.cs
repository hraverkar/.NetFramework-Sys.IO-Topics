/* 
The prototype pattern copies or clones an existing class, rather than creating a new instance, 
when creating new instances is more expensive.
*/

using System;
using System.Collections.Generic;

/*  Prototype Design pattern is one of the creational design pattern.
 * Prototype pattern is specifically used when creating a duplicate object  of an existing object while attemping to c
 * conserve resources and focus on performance.
 *
 *
 */

namespace ConsoleApp163
{
  internal static class Program
  {
    private static void Main()
    {
      var dev = new Developer();
      dev.FirstName = "Harshal Raverkar";
      dev.LastName = "Bangalore";
      dev.Skills = new List<string> {"C#", "Angular", "POSTSQL", "JaveScript"};


      var dev2 = dev.Clone() as Developer;
      Console.WriteLine("The cloned developer name is " +dev.FirstName +" :: "+ dev.LastName );
      Console.WriteLine("The Second developer has the following skills ::");

      foreach (var VARIABLE in dev2.Skills)
      {
       Console.WriteLine(VARIABLE); 
      }

      dev2.Skills.Add("Java");

      foreach (var VARIABLE in dev.Skills)
      {
        Console.WriteLine(VARIABLE);
      }
    }
  }



  class Developer : ICloneable
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> Skills { get; set; }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}
