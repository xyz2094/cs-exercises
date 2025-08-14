namespace aug13
{
  public class Program
  {
    static void Main()
    {
      List<decimal> prices = new List<decimal>
      {
        799.90m, 1200.00m, 3500.50m, 999.99m, 1500.00m
      };
      int count = 0;
      foreach (decimal price in prices)
      {
        if (price > 1000)
        {
          count++;
        }
      }
      Console.WriteLine($"Products price: {string.Join(" | ", prices)}");
      Console.WriteLine($"There are {count} products expensiver 1000$.");
    }
  }
}