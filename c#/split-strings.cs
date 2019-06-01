  /*
 Name: Shay Pepper
 Date: 01/06/2019
 Title: Split Strings
 Kata: https://www.codewars.com/kata/split-strings/
 */
 


public class SplitString
{
  public static string[] Solution(string str)
  {
    if(str.Length%2!=0)
    {
    str+="_";
    }
    int len = str.Length/2;

    string[] result = new string[len];
    for(int i=0;i<len;i++)
    {
      result[i] = str[2*i].ToString()+str[2*i+1].ToString();
    }

    return result;
  }
}
