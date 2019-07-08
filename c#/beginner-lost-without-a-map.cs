 /*
 Name: Shay Pepper
 Date: 08/07/2019
 Title: Beginner - Lost Without a Map
 Kata: https://www.codewars.com/kata/beginner-lost-without-a-map/csharp
 */

public class Kata
{
	public static int[] Maps(int[] x)
	{
		for (int i = 0; i < x.Length; i++)
		{
			x[i] *= 2;
		}

		return x;
	}
}
