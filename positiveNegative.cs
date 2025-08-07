using System.Xml.Schema;

namespace first_steps
{
  public class ex1
  {
    static void Main()
    {
      float num;

      System.Console.Write("Enter a number: ");
      float.TryParse(System.Console.ReadLine(), out num);
      if (num >= 0)
      {
        System.Console.WriteLine("The number is positive.");
      }
      else
      {
        System.Console.WriteLine("The number is negative.");
      }



    }
  }
}