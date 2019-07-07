  
/*
 Name: Shay Pepper
 Date: 07/07/2019
 Title: How good are you really?
 Kata: https://www.codewars.com/kata/how-good-are-you-really/csharp
 */


using System.Linq;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    return YourPoints > ClassPoints.Average();
  }
}
