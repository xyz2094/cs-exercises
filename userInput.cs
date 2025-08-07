using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int age;
      string name;
      double height;
      bool is_active;
      char letter;

      System.Console.Write("Enter your name: ");
      name = System.Console.ReadLine();

      System.Console.Write("Enter your age: ");
      age = int.Parse(System.Console.ReadLine());

      System.Console.Write("Enter your height in meters: ");
      height = double.Parse(System.Console.ReadLine());

      System.Console.Write("Are you active? (true/false): ");
      is_active = bool.Parse(System.Console.ReadLine());

      System.Console.Write("Enter a letter: ");
      letter = char.Parse(System.Console.ReadLine());

      System.Console.WriteLine($"\nName: {name}");
      System.Console.WriteLine($"Age: {age}");
      System.Console.WriteLine($"Height: {height}");
      System.Console.WriteLine($"Is Active: {is_active}");
      System.Console.WriteLine($"Letter: {letter}\n");

    }

  }
}