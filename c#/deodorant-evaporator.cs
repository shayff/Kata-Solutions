 /*
 Name: Shay Pepper
 Date: 31/05/2019
 Title: Deodorant Evaporator
 Kata: https://www.codewars.com/kata/deodorant-evaporator
 */
 
public class Evaporator 
{   
  public static int evaporator(double content, double evap_per_day, double threshold) 
  {
    int numOfDays=0;
    double outOfUseAmount = content * threshold / 100;
    while(content>outOfUseAmount)
    {
      content *= 1 - evap_per_day / 100;
      numOfDays++;
    }
    return numOfDays;
  }
}
