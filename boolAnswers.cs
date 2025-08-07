using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {

    public const int answer = 5;

    static void Main()
    {

      int countTrue = 0;

      for (int i = 0; i < answer; i++)
      {
        System.Console.Write("Do you like programming? (true/false): ");
        bool answer = bool.Parse(System.Console.ReadLine());

        if (answer == true)
        {
          countTrue++;
        }
      }
      System.Console.WriteLine($"\nTrue answers: {countTrue}");
      System.Console.WriteLine($"False answers: {answer - countTrue}");
    }
  }
}