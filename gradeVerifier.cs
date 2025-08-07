using System.Xml.Schema;

namespace first_steps
{
  public class ex1
  {
    static void Main()
    {
      int grade;

      System.Console.Write("Enter your grade: ");
      int.TryParse(System.Console.ReadLine(), out grade);
      if (grade >= 60)
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