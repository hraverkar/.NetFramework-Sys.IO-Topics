using System;
using System.IO;

namespace ConsoleApp159
{
  class Program
  {
    public static void Main()
    {
      DriveInfo[] allDrives = DriveInfo.GetDrives();
      foreach (var variable in allDrives)
      {
        Console.WriteLine("Drive :: " + variable.Name);
        Console.WriteLine(" Drive type :: "+ variable.DriveType);
        if (variable.IsReady)
        {
          Console.WriteLine("Volume label :: " + variable.VolumeLabel);
          Console.WriteLine("File System :: "+ variable.DriveFormat);
          Console.WriteLine(" Available free space to current  :: "+variable.AvailableFreeSpace);

          Console.WriteLine(" Total Available space :: " +variable.TotalFreeSpace);
          Console.WriteLine("Total size of drive "+variable.TotalSize);
        }
      }
    }
  }
}
