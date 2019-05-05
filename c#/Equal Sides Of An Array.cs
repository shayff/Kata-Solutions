/*
Name: Shay Pepper
Date: 05/05/19
Kata: https://www.codewars.com/kata/equal-sides-of-an-array/
*/

using System.Linq;

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int leftSum = 0;
    int rightSum = arr.Sum()-arr[0];
    
    for(int i = 1 ; i<arr.Length; ++i)
    {
      leftSum+=arr[i-1];
      rightSum-=arr[i];
      if(leftSum == rightSum)
      {
        return i;
      }
    }
    return -1;
  }
}
