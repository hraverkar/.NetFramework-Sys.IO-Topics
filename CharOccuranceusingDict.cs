using System;
using System.Collections.Generic;

namespace ConsoleApp191
{
  internal static class Technical
  {
    public static void Main()
    {
      var dict = new Dictionary<char, int>();
      const string str = "khandwa";
      var c = str.ToCharArray();
      foreach (var ch in c)
      {
        if (dict.ContainsKey(ch))
        {
          dict[ch]++;
        }
        else
        {
          dict.Add(ch, 1);
        }
      }

      foreach (var variable in dict.Keys)
      {
        Console.WriteLine(variable +" : "+ dict[variable]);
      }
    }
  }
}
