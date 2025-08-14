namespace aug13
{
  public class Program
  {
    static void Main()
    {
      List<decimal> grades = new List<decimal>();

      List<decimal> inputGrades = new List<decimal> { 5.5m, 6.0m, 7.2m, 4.8m, 8.0m };

      foreach (decimal grade in inputGrades)
      {
        grades.Add(grade);
      }
      foreach (decimal grade in grades)
      {
        if (grade >= 6.00m)
        {
          Console.WriteLine($"Grade: {grade} - Approved");
        }
        else
        {
          Console.WriteLine($"Grade: {grade} - Failed");
        }
      }
    }
  }
}




