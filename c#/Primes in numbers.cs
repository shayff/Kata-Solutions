/*
 Name: Shay Pepper
 Date: 12/05/2019
 Title: Primes in numbers.
 Kata: https://www.codewars.com/kata/primes-in-numbers
 */


using System;

public class PrimeDecomp {

	public static String factors(int lst) {
    string result = null;
    int PrimeToCheck=2;
    int count =0;
    while(lst>1)
    {
      while(lst%PrimeToCheck==0)
      {
        ++count;
        lst/=PrimeToCheck;
      }
      if(count==1)
      {      
       result += String.Format("({0})",PrimeToCheck);
      }
      else if(count>1)
      {
         result += String.Format("({0}**{1})",PrimeToCheck, count) ;
      }      
    ++PrimeToCheck;
    count=0;
    }
    return result;
  }
}
