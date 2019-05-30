    
 /*
 Name: Shay Pepper
 Date: 30/05/2019
 Title: Is It Negative Zero (-0)?
 Kata: https://www.codewars.com/kata/is-it-negative-zero-0
 */

public static class Kata 
{
    public static bool IsNegativeZero(double n) 
    {      
     return n == 0.0 && double.IsNegativeInfinity(1.0 / n);
    }
}
