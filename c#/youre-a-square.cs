 /*
 Name: Shay Pepper
 Date: 23/05/2019
 Title: You're a square!
 Kata: https://www.codewars.com/kata/youre-a-square
 */
 
using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    return Math.Sqrt(n) % 1 == 0;
  }
}
