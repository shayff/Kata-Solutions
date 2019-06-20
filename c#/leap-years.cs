  /*
 Name: Shay Pepper
 Date: 20/06/2019
 Title: Leap Years
 Kata: https://www.codewars.com/kata/leap-years
 */


using System;

public static class Kata
{
  public static bool IsLeapYear(int year)
  {
    if(year % 400 == 0) return true;
    if(year % 100 == 0) return false;
    return year % 4 == 0;
  }
}
