/*
Date: 23/02/2019
No: 001

*/

#include <vector>
int findOdd(const std::vector<int>& numbers) {
	
	bool flag = true; //true=odd, false=even
	for (int i = 0; i < numbers.size(); i++)
	{
		flag = false;
		for (int j = 0; j < numbers.size(); j++)
		{
			if (numbers[j] == numbers[i])
				flag = !flag;
		}
		if (flag == true)
			return numbers[i];
	}
}
