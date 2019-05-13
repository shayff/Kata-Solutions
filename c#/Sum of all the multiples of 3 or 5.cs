/*
 Name: Shay Pepper
 Date: 13/05/2019
 Title: Sum of all the multiples of 3 or 5
 Kata: https://www.codewars.com/kata/sum-of-all-the-multiples-of-3-or-5/
 */
 
namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
    int sum=0;
     for(int i=0;i<=n;++i)
     {
       if( i%3==0 || i%5==0 )
       {
        sum+=i;
       }     
     }
      return sum;
    }
  }
}
