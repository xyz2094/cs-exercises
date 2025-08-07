using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class ex1
  {
    static void Main()
    {
      for (int i = 0; i < 10; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine($"Even number: {i}");
        }
        else
        {
          Console.WriteLine($"Odd number: {i}");
        }
      }

    }
  }
}