using System.Xml.Schema;

namespace first_steps
{
  public class ex1
  {
    static void Main()
    {
      int num;

      System.Console.Write("Enter a number: ");
      int.TryParse(System.Console.ReadLine(), out num);
      if (num % 2 == 0)
      {
        System.Console.WriteLine("The number is even.");
      }
      else
      {
        System.Console.WriteLine("The number is odd.");
      }



    }
  }
}