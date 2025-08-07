using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {
    static void Main()
    {
      int grade;

      System.Console.Write("Enter your grade: ");
      int.TryParse(System.Console.ReadLine(), out grade);
      if (grade >= 6.0)
      {
        System.Console.WriteLine("You passed the exam.");
      }
      else
      {
        System.Console.WriteLine("You failed the exam.");
      }
    }
  }
}