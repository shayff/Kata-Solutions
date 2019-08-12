/*
 Name: Shay Pepper
 Date: 15/05/2019
 Title: Bin to Decimal
 Kata: https://www.codewars.com/kata/bin-to-decimal
 */

using System;

namespace Solution
{
  public static class Program
  {
    public static int binToDec(string s)
    {
      return Convert.ToInt32(s,2);
    }
  }
}
