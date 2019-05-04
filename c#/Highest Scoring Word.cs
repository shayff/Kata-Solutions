   
/*
Highest Scoring Word.cpp
Name: Shay Pepper
Date: 04/05/19
https://www.codewars.com/kata/highest-scoring-word
*/

public class Kata
{
  public static string High(string s)
  {
     string[] words = s.Split(' ');
     int maxIndex=0;
     int maxScore=0;
     
     for(int i=0;i<words.Length;++i)
     {
       if(scoreOfWord(words[i]) > maxScore)
       {
       maxScore=scoreOfWord(words[i]);
       maxIndex=i;
       }
     }
  return words[maxIndex];
  }
  
  public static int scoreOfWord(string i_Word)
  {
  int score=0;
  
  for(int i=0;i<i_Word.Length;++i)
  {
    score+=i_Word[i]-'a'+1; 
   }
  return score;
  }
}
