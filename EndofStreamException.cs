using System;
using System.IO;

namespace ConsoleApp159
{
  static class Program
  {
    public static void Main()
    {
      int i;
      const int arrayLength = 1000;
      var randomGenerator = new Random();
      var dataArray = new double[arrayLength];

      for (i = 0; i < arrayLength; i++)
      {
        dataArray[i] = 100.1 * randomGenerator.NextDouble();
      }

      using (var brw = new BinaryWriter(new MemoryStream()))
      {
        Console.WriteLine("Writing data to stream :: ");
        for (i = 0; i < arrayLength; i++)
        {
          brw.Write(dataArray[i]);
        }

        using (var br = new BinaryReader(brw.BaseStream))
        {
          try
          {
            br.BaseStream.Position = 0;
            Console.WriteLine("Verifying the written data :: ");
            for (i = 0; i < arrayLength; i++)
            {
              if (br.ReadDouble() != dataArray[i])
              {
                Console.WriteLine("Error Writing data");
                break;
              }
            }

            Console.WriteLine("The data was written and verified");
          }
          catch (Exception e)
          {
            Console.WriteLine(e.Message);
          }

        }

      }

    }
  }
}
