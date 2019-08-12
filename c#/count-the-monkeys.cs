    
 /*
 Name: Shay Pepper
 Date: 12/08/2019
 Title: Count the Monkeys!
 Kata: https://www.codewars.com/kata/count-the-monkeys/
 */


public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[i] = i+1;
        }
        return res;
    }
}
