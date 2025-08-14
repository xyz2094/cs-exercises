namespace aug13
{
  public class Program
  {
    static void Main()
    {
      List<(string name, decimal price)> items = new()
      {
        ("Pen", 3.50m),
        ("Notebook", 15.00m),
        ("Backpack", 120.00m),
        ("Pencil", 2.00m),
        ("Calculator", 75.00m)
      };
      foreach (var item in items)
      {
        if (item.price > 50)
        {
          Console.WriteLine($"{item.name}: R$ {item.price} - Expensive!");
        }
        else
        {
          Console.WriteLine($"{item.name}: R$ {item.price}");
        }
      }
    }
  }
}