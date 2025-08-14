namespace aug13
{
  public class Program
  {
    static void Main()
    {
      var words = new List<string>
      {
        "apple", "banana", "cherry", "date", "elderberry", "fig", "grape"
      };
      int count = 0;
      foreach (var word in words)
      {
        if (word.Length > 5)
        {
          count++;
        }
      }
      Console.WriteLine("Words: " + string.Join(", ", words));
      Console.WriteLine($"\nWords with more than 5 letters: {count}");
    }
  }
}