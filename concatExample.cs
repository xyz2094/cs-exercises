using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int age = 21;
      string name = "Vittor Dallacqua";
      double height = 1.74;
      bool is_active = true;
      char letter = 'v';
      bool likeProgramming = true;

      System.Console.WriteLine($"My name is {name}, I am {age} years old, my height is {height}m, I am active: {is_active}, my initial letter is '{letter}', and it's {likeProgramming} that I like to programming.");
    }
  }
}