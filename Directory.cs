using System;
using System.IO;
using Microsoft.VisualBasic;

namespace ConsoleApp159
{
  internal static class Test
  {/*
    Directory Class :: creating, moving and
    enumerating through directories and sub
    directories. 
    This class can not be inherited.
    */
    private class Program
    {
      public static void Main(string[] args)
      {
        const string sourceDirectory = @"C:\Current";
        const string archiveDirectory = @"C:\Archive";
        try
        {
          var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");
          foreach (var variable in txtFiles)
          {
            string fileName = variable.Substring(sourceDirectory.Length+1); 
            Directory.Move(variable, Path.Combine(archiveDirectory,fileName));
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }

      }
    }
   
  }
}
