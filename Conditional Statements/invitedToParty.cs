using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int age;
      bool wasInvited;

      System.Console.Write("Enter your age: ");
      age = int.Parse(System.Console.ReadLine());

      System.Console.Write("You were invited to the party? (true/false): ");
      wasInvited = bool.Parse(System.Console.ReadLine());

      if (age >= 18 && wasInvited)
      {
        System.Console.WriteLine("You can enter the party.");
      }
      else
      {
        System.Console.WriteLine("You cannot enter the party.");
      }

    }
  }
}