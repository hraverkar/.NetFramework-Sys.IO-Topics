using System;
using System.IO;

namespace ConsoleApp159
{
  internal static class Program
  {
    public static void Main()
    {
      var fsw = new FileSystemWatcher("C:\\")
      {
        NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName |
                       NotifyFilters.DirectoryName
      };
      fsw.Changed += OnChanged;
      fsw.Created += OnChanged;
      fsw.Deleted += OnChanged;
      fsw.Renamed += OnRenamed;
      fsw.Error += OnError;
      fsw.EnableRaisingEvents = true;
      Console.WriteLine("Press enter the quit");

    }

    private static void OnRenamed(object sender, RenamedEventArgs e)
    {
      var wct = e.ChangeType;
      Console.WriteLine("File :: " + e.OldFullPath + " :: " + wct.ToString() +" :: "+ e.FullPath);
    }

    private static void OnError(object sender, ErrorEventArgs e)
    {
      Console.WriteLine("The file System watcher has detected an error");
      if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
      {
        Console.WriteLine(("The file system watcher internal buffer overflow :: "+ e.GetException().Message ));
      }
    }

    private static void OnChanged(object sender, FileSystemEventArgs e)
    {
      var wct = e.ChangeType;
      Console.WriteLine("File :: "+ e.FullPath + ":: "+ wct.ToString());
    }
  }
}
