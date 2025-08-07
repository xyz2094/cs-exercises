using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int a = 10;
      int b = 20;
      double c = 15.74;
      double d = 33.29;

      int sum = a + b;
      double sumDouble = c + d;

      System.Console.WriteLine($"The sum of {a} and {b} is {sum}.");
      System.Console.WriteLine($"The sum of {c} and {d} is {sumDouble}.");
    }

  }
}