/*
Name: Shay Pepper
Date: 03/05/19
Kata: https://www.codewars.com/kata/highest-and-lowest/
*/

using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] splitedNumbers = numbers.Split(' ');
    int.TryParse(splitedNumbers[0],out int numToCompare);
    int Min=numToCompare, Max=numToCompare;
    
    for (int i=1;i<splitedNumbers.Length;++i)
    {
        int.TryParse(splitedNumbers[i],out numToCompare);
        if(Min<numToCompare)
        {
          Min=numToCompare;
        }
         if(Max>numToCompare)
        {
          Max=numToCompare;
        }
    }
    return String.Concat(Min.ToString(), ' ', Max.ToString());
  }
}
