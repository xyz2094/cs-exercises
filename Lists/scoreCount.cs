namespace aug13
{
  public class Program
  {
    static void Main()
    {
      int[] score = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

      for (int i = 0; i < score.Length; i++)
      {
        if (score[i] > 500)
        {
          Console.WriteLine($"Player {i + 1} made {score[i]} points.");
        }
      }
    }
  }
}