/**
*
* Introduction to programming course
* Winter semester 2024/2025
* Faculty of Mathematics and Informatics of Sofia University
* @author Aneliya Petkova
* @FN 0MI0700322
*
* Homework 1
* Task 4: Factorial
*
* Write a program that, given a positive integer n, outputs n! (the factorial of n).
*
*/

#include <iostream>
using namespace std;

unsigned long long calculateFactorial(int n);

int main() {
	int n;
	unsigned long long factorial;

	// Enter a positive integer n
	cin >> n;

	if (n < 0)
	{
		cout << "Invalid number!" << endl;

		return -1;
	}

	factorial = calculateFactorial(n);

	cout << factorial;

	return 0;
}

// Function for calculating the factorial of n
unsigned long long calculateFactorial(int n)
{
	if (n == 0)
	{
		return 1;
	}

	return n * calculateFactorial(n - 1);
}