using System;
using System.IO;

namespace ConsoleApp159
{
  internal static class Test
  {
    /*  This tyoe implements the IDisposable interface. When you have finished 
     *
     * Retrive application setting in a file - Binary Reader class provides method
     * that simplify reading primitive data types from a stream.
     * You can use the ReadBoolean method to read the next byte as a Boolean value and advance the
     * current position.
     *
     */

    private const string fileName = "AppSettings.dat";

    public static void Main(string[] args)
    {
      WriteDefaultValues();
      DisplayValues();
    }

    private static void DisplayValues()
    {
      float aspectRatio;
      string tempDirectory;
      int autoSaveTime;
      bool showStatusBar;
      if (File.Exists(fileName))
      {
        using (BinaryReader br = new BinaryReader(File.Open(fileName,FileMode.Open)))
        {
          aspectRatio = br.ReadSingle();
          tempDirectory = br.ReadString();
          autoSaveTime = br.ReadInt32();
          showStatusBar = br.ReadBoolean();
        }

        Console.Out.WriteLine("Aspect Radio is :: "+aspectRatio);
        Console.Out.WriteLine("Temp Directorate is :: "+tempDirectory);
        Console.Out.WriteLine("Auto save time set to :: "+autoSaveTime);
        Console.Out.WriteLine("Show status bar :: "+showStatusBar);
        
      }
      
    }

    private static void WriteDefaultValues()
    {
      using BinaryWriter bwr = new BinaryWriter(File.Open(fileName,FileMode.Create));
      bwr.Write(1.25f);
      bwr.Write(@"C:\temp");
      bwr.Write(10);
      bwr.Write(true);
    }
  }
}
