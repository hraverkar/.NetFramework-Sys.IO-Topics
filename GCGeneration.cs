using System;
using System.Text.RegularExpressions;

/*
 * GC class : : Controls the system garbage collector, a service that automatically
 * reclaims unused memory::
 *
 *
 */
namespace ConsoleApp160
{
  class MyGCCollectClass
  {
    private const long maxGarbage = 1000;

    static void Main()
    {
      MyGCCollectClass mg = new MyGCCollectClass();
      Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);
      mg.MakeSomeGarbage();
      Console.WriteLine("Generation ::{0}", GC.GetGeneration(mg));

      Console.WriteLine("Total memory :: {0}", GC.GetTotalMemory(false));
      GC.Collect(0);
      Console.WriteLine("Generation : {0}", GC.GetGeneration(mg));
      Console.WriteLine("Total Memory :: {0} ", GC.GetTotalMemory(false));

      GC.Collect(2);
      Console.WriteLine("Generation: {0}", GC.GetGeneration(mg));
      Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

    }

    private void MakeSomeGarbage()
    {
      Version vt;
      for (int i = 0; i <maxGarbage; i++)
      {
        vt = new Version();
      }
    }
  }
}
