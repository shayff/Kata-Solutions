/*
 Name: Shay Pepper
 Date: 03/07/2019
 Title: Disarium Number (Special Numbers Series #3)
 Kata: https://www.codewars.com/kata/disarium-number-special-numbers-series-number-3/csharp
 */

using System;

class Kata
{
	public static string DisariumNumber(int number)
	{
		int compare = number;
		int Reverse = 0;
		int sum = 0;
		double i = 1;
		while (number > 0)
		{
			Reverse = (Reverse * 10) + number % 10;
			number /= 10;
		}

		while (Reverse > 0)
		{
			sum += (int)Math.Pow((double)Reverse % 10, i);
			Reverse /= 10;
			i++;
		}

		if (sum == compare)
		{
			return "Disarium !!";
		}
		else
		{
			return "Not !!";
		}
	}
}
