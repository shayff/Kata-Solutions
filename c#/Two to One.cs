 /*
 Name: Shay Pepper
 Date: 06/05/2019
 Two to One.cs
 Kata: https://www.codewars.com/kata/two-to-one/csharp
 */
 
 using System;   
using System.Linq;

public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
  {
        string mergedString = s1 + s2;
        char []charArray = mergedString.ToCharArray();  
        Array.Sort(charArray); 
              
    return string.Join("", charArray.Distinct());
  }
}
