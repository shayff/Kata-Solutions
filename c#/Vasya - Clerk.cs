 Name: Shay Pepper
 Date: 07/05/2019
 Title: Vasya - Clerk
 Kata: https://www.codewars.com/kata/vasya-clerk/train/csharp
 */

using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
           int Bill25 = 0, Bill50=0;
           for(int i=0;i<peopleInLine.Length;++i)
           {      
           switch (peopleInLine[i])
            {
                case 25:
                    ++Bill25;
                    break;            
                case 50:
                    if(Bill25>=1)
                     {
                        --Bill25;
                        ++Bill50;
                    }
                    else
                    {
                      return "NO";
                    }
                    break;             
                case 100:
                    if(Bill50>=1 && Bill25>=1)
                      {
                        --Bill25;
                        --Bill50;
                      }
                      else if(Bill25>=3)
                      {
                        Bill25-=3;
                      }
                      else
                      {
                       return "NO";
                      }
                    break;             
            }               
           }
           return "YES";           
        }
    }
