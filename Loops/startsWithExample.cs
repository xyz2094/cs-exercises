using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int countA = 0;

      for (int i = 0; i < 5; i++)
      {
        System.Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (name.StartsWith("A"))
        {
          countA++;
        }
      }
      System.Console.WriteLine($"Number of names starting with 'A': {countA}");
    }
  }
}