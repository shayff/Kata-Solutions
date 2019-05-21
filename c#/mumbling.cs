 /*
 Name: Shay Pepper
 Date: 21/05/2019
 Title: Mumbling
 Kata: https://www.codewars.com/kata/mumbling/
 */

using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
     char[] words = s.ToLower().ToCharArray();
     string res="";
     for (int i=0;i<s.Length;i++)
     {
       res+=Char.ToUpper(words[i]) + new String(words[i], i) + "-" ;
     }
     return res.Substring(0, res.Length - 1); 
  }
}
