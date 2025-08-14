namespace aug13
{
  public class Program
  {
    static void Main()
    {
      List<string> backpack = new List<string>();

      List<string> items = new List<string>
      {
        "Notebook",
        "Water Bottle",
        "Pen",
        "Wallet",
      };

      while (true)
      {
        backpack.AddRange(items);
        Console.WriteLine("Type 'Ctrl+C' to quit.");
        Console.Write("What do you need from your backpack? ");

        string? input = Console.ReadLine();
        string item = input ?? string.Empty;

        if (backpack.Contains(item))
        {
          Console.WriteLine($"Yes, you have {item} in your backpack.\n");
        }
        else
        {
          Console.WriteLine($"No, you don't have {item} in your backpack.\n");
        }
      }
    }
  }
}
