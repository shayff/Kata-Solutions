  /*
 Name: Shay Pepper
 Date: 06/06/2019
 Title: Sexy Primes <3
 Kata: https://www.codewars.com/kata/sexy-primes-%3C3/csharp
 */

public class Kata
{
  public static bool SexyPrime(int x, int y)
  { 
    bool flag = false;
    if(Math.Abs(x-y)==6)
    {
      if(isPrime(x) && isPrime(y))
      {
        flag=true;
      }
    }    
    return flag;
  }
  
  public static bool isPrime(int i_Number)
  {
    if(i_Number==1 || i_Number==2)
    {
      return true;
    }
    for (int i = 2; i < i_Number; i++) 
    {
       if (i_Number % i == 0) 
       {
          return false;
       }
    }
    return true;
  }
}
