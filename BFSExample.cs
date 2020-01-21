using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
  public class Employee
  {
    public string Name { get; set; }
    public Employee(string name)
    {
      this.Name = name;
    }

    public List<Employee> EmployeeList = new List<Employee>();

    public List<Employee> Employees
    {
      get
      {
        return EmployeeList;
      }
    }

    public void IsEmployeeOf(Employee p)
    {
      EmployeeList.Add(p);
    }

    public override string ToString()
    {
      return Name;
    }
  }

  public class BreadthFirstAlgorithm
  {
    public Employee BuildEmployeeGraph()
    {
      Employee Eva = new Employee("Eva");
      Employee Sophia = new Employee("Sophia");
      Employee Brian = new Employee("Brian");
      Eva.IsEmployeeOf(Sophia);
      Eva.IsEmployeeOf(Brian);

      Employee Lisa = new Employee("Lisa");
      Employee Tina = new Employee("Tina");
      Employee John = new Employee("John");
      Employee Mike = new Employee("Mike");
      Sophia.IsEmployeeOf(Lisa);
      Sophia.IsEmployeeOf(John);
      Brian.IsEmployeeOf(Tina);
      Brian.IsEmployeeOf(Mike);

      return Eva;
    }
    public Employee Search(Employee root, string nameToSearchFor)
    {
      Queue<Employee> Q = new Queue<Employee>();
      HashSet<Employee> S = new HashSet<Employee>();
      Q.Enqueue(root);
      S.Add(root);

      while (Q.Count > 0)
      {
        Employee e = Q.Dequeue();
        if (e.Name == nameToSearchFor)
          return e;
        foreach (Employee friend in e.Employees)
        {
          if (!S.Contains(friend))
          {
            Q.Enqueue(friend);
            S.Add(friend);
          }
        }
      }
      return null;
    }

    public void Traverse(Employee root)
    {
      Queue<Employee> traverseOrder = new Queue<Employee>();

      Queue<Employee> Q = new Queue<Employee>();
      HashSet<Employee> S = new HashSet<Employee>();
      Q.Enqueue(root);
      S.Add(root);

      while (Q.Count > 0)
      {
        Employee e = Q.Dequeue();
        traverseOrder.Enqueue(e);

        foreach (Employee emp in e.Employees)
        {
          if (!S.Contains(emp))
          {
            Q.Enqueue(emp);
            S.Add(emp);
          }
        }
      }

      while (traverseOrder.Count > 0)
      {
        Employee e = traverseOrder.Dequeue();
        Console.WriteLine(e);
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      BreadthFirstAlgorithm b = new BreadthFirstAlgorithm();
      Employee root = b.BuildEmployeeGraph();
      Console.WriteLine("Traverse Graph\n------");
      b.Traverse(root);

      Console.WriteLine("\nSearch in Graph\n------");
      Employee e = b.Search(root, "Eva");
      Console.WriteLine(e == null ? "Employee not found" : e.Name);
      e = b.Search(root, "Brian");
      Console.WriteLine(e == null ? "Employee not found" : e.Name);
      e = b.Search(root, "Soni");
      Console.WriteLine(e == null ? "Employee not found" : e.Name);

    }
  }
}
