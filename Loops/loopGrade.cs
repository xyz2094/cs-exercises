using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace first_steps
{
  public class Program
  {

    public const int grades = 5;

    static void Main()
    {
      int countApproved = 0;

      for (int i = 0; i < grades; i++)
      {
        System.Console.Write("Enter the grade: ");
        double grade = double.Parse(System.Console.ReadLine());

        if (grade >= 6.0)
        {
          countApproved++;
        }
      }
      System.Console.WriteLine($"\nApproved: {countApproved}");
      System.Console.WriteLine($"Not approved: {grades - countApproved}");
    }
  }
}