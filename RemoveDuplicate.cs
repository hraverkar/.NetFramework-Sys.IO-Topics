using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp29
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "harshalraverkar";

      removeDuplicate(str);
    }

    private static void removeDuplicate(string str)
    {
      int count = 0;
      Dictionary<char, int> dict = new Dictionary<char, int>();
      var ch = str.ToCharArray();
      for(int i =0;i<ch.Length;i++)
      {
        if (dict.ContainsKey(ch[i]))
        {
          count++;
        }
        else
        {
          dict.Add(ch[i], i);
        }
      }

      foreach(var i in dict)
      {
        Console.Write(i.Key);
      }
    }
  }
}
