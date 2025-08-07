using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {

    public const int letters = 5;

    static void Main()
    {

      char letter;

      for (int i = 0; i < letters; i++)
      {
        System.Console.Write("Enter the letters: ");
        letter = System.Console.ReadKey().KeyChar;

        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
          System.Console.WriteLine($"\n{letter} is a vowel");
        }
        else
        {
          System.Console.WriteLine($"\n{letter} is a consonant");
        }
      }
    }
  }
}