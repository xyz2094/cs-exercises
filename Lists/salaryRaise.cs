namespace aug13
{
  public class Program
  {
    static void Main()
    {
      decimal[] salaries = { 2500.00m, 3200.00m, 1500.00m, 4000.00m, 2800.00m };
      for (int i = 0; i < salaries.Length; i++)
      {
        if (salaries[i] < 3000.00m)
        {
          salaries[i] *= 1.10m;
        }
      }
      foreach (var salary in salaries)
      {
        Console.WriteLine(salary.ToString("f2"));
      }
    }
  }
}
