namespace aug13
{
  public class Program
  {
    static void Main()
    {
      string[] songs = new string[]{
        "Wage Slaves",
        "Sweet Child O' Mine",
        "Join the Club",
        "Chelsea Smile",
        "Eruption"
      };
      foreach (string song in songs)
      {
        if (song == "Sweet Child O' Mine")
        {
          Console.WriteLine($"{song} - This one is a banger!");
        }
        else
        {
          Console.WriteLine(song);
        }
      }
    }
  }
}




