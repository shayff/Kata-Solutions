/*
 Name: Shay Pepper
 Date: 16/05/2019
 Title: Are they the "same"?
 Kata: https://www.codewars.com/kata/are-they-the-same 
 */

using System;
using System.Linq;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
  if(a==null && b==null)
  {
    return true;
  }    
  else if(a==null || b==null)
  {
    return false;
  }
      
  int[] a_arr = a.OrderBy(x => x).Select(x => x*x).ToArray();
  int[] b_arr = b.OrderBy(x => x).ToArray();
  return  a_arr.SequenceEqual(b_arr);
  }
}
