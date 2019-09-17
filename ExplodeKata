using System;
using System.Linq;

namespace digits_explosion_kata
{

  public class Digits
  {
    public static string Explode(string s)
    {
      //not doing it on index doing it on value so use one parameter on select
      var x = String.Join("",
      s.Select(
          (letter, i) =>
          String.Join("", Enumerable.Repeat(letter, (int)Char.GetNumericValue(letter)))));

      return x;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

