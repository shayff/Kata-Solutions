/*
Name: Shay Pepper
 Date: 08/05/2019
 Title: Persistent Bugger.
 Kata: https://www.codewars.com/kata/persistent-bugger/csharp
 */


using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
    int i=0;
		while(n>9)
    {
      n=MulDigits(n);
      ++i;
    }
    return i;
	}
  
  public static long MulDigits(long num)
  {
    long res=1;
    while(num>0)
    {
      res*=num%10;
      num/=10;
    }
    return res;
  }
}
