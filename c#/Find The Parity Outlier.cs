/*
Name: Shay
Date: 05/02/19
Kata: https://www.codewars.com/kata/find-the-parity-outlier
*/


public class Kata
{
  public static int Find(int[] integers)
  {
  
  bool v_IsLookForEven;
  
    if(isEven(integers[0])==isEven(integers[1]))
    //If both first are even we look for odd, if both odd we look for even
    {
      v_IsLookForEven=!isEven(integers[0]);
      for(int i=2;i<integers.Length;i++)
      {
         if(isEven(integers[i])==v_IsLookForEven)
         {
          return integers[i];
         }
       }
    }
    else
    {
    //If first different from second we check the third and decide if return first or second
      if(isEven(integers[0])==isEven(integers[2]))
      {
      return integers[1];
      }
      else
      {
      return integers[0];
      }
    } 
  return -1;
  }
  
    public static bool isEven(int i_Number)
    {
      return i_Number%2==0;
    }
}
