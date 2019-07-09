 /*
 Name: Shay Pepper
 Date: 09/07/2019
 Title: Delta Bits
 Kata: https://www.codewars.com/kata/delta-bits/csharp
 */

public class DeltaBits
{
	public static int ConvertBits(int a, int b)
	{
		int counter = 0;
		while (a > 0 || b > 0)
		{
			if (a % 2 != b % 2)
			{
				counter++;
			}

			a /= 2;
			b /= 2;
		}

		return counter;
	}
}
