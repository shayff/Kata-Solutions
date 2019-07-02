 /*
 Name: Shay Pepper
 Date: 01/07/2019
 Title: By 3, or not by 3? That is the question . . .
 Kata: https://www.codewars.com/kata/by-3-or-not-by-3-that-is-the-question
 */


using System;

public static class Kata
{
  public static bool DivisibleByThree(string n)
  {
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        sum += Convert.ToInt32(n.Substring(i, 1));
    }
    return sum%3 == 0;
  }
}
