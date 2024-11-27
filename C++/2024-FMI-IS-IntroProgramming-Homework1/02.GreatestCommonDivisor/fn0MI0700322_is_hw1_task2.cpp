/**
*
* Introduction to programming course
* Winter semester 2024/2025
* Faculty of Mathematics and Informatics of Sofia University
* @author Aneliya Petkova
* @FN 0MI0700322
*
* Homework 1
* Task 2: Greatest Common Divisor
*
* Write a program that, given two positive integers a and b,
* determines and outputs their greatest common divisor.
*
*/

#include <iostream>;
using namespace std;

int main() {
	int a, b,
		greatestCommonDivisor = 0,
		biggestNumber = 0;

	// Enter positive integer a
	cin >> a;

	// Enter positive integer b
	cin >> b;

	if (a <= 0 || b <= 0)
	{
		cout << "Invalid numbers!" << endl;

		return -1;
	}

	if (a >= b)
	{
		biggestNumber = a;
	}
	else
	{
		biggestNumber = b;
	}

	for (int i = biggestNumber; i >= 1; i--)
	{
		if (a % i == 0 && b % i == 0)
		{
			greatestCommonDivisor = i;

			break;
		}
	}

	cout << greatestCommonDivisor;

	return 0;
}