namespace aug13
{
  public class Program
  {
    static void Main()
    {
      List<string> friends = new List<string>
      {
        "Alice",
        "Bruno",
        "Ana",
        "Carlos",
        "Amanda",
        "Daniel"
      };

      var startsWithA = friends.Where(name => name.StartsWith("A")).ToList();

      foreach (var friend in startsWithA)
      {
        Console.WriteLine(friend);
      }
    }
  }
}