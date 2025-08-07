using System.Xml.Schema;

namespace first_steps
{
  public class ex1
  {
    static void Main()
    {
      int age = 21;

      if (age >= 18)
      {
        System.Console.WriteLine("You are an adult.");
      }
      else
      {
        System.Console.WriteLine("You are a minor.");
      }
    }
  }
}