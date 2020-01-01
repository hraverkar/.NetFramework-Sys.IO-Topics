using System;
using System.Reflection;

namespace ConsoleApp189
{
  internal class Test
  {
    private void Magic()
    {
      Console.WriteLine("Hello Harshal Raverkar");
    }
  }

  internal static class Program
  {
    private static void Main()
    {
      var test = new Test();
      var type = typeof(Test);
      var methodInfo = type.GetMethod("Magic", BindingFlags.Instance | BindingFlags.NonPublic);

      if (methodInfo == null) return;
      var methodName = methodInfo.Name;
      Console.WriteLine(methodName);
      var value = methodInfo.Invoke(test, null);
      Console.WriteLine(value);
    }
  }
}
