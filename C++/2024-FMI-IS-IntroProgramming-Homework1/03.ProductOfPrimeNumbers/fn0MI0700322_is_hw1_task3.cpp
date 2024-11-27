/**
*
* Introduction to programming course
* Winter semester 2024/2025
* Faculty of Mathematics and Informatics of Sofia University
* @author Aneliya Petkova
* @FN 0MI0700322
*
* Homework 1
* Task 3: Product of Prime Numbers
*
* Write a program that given a positive integer,
* outputs its representation as a product of prime numbers.
*
*/

#include <iostream>;
using namespace std;

int main() {
	int n;

	// Enter a positive integer n
	cin >> n;

	if (n <= 0)
	{
		cout << "Invalid number!" << endl;

		return -1;
	}

	if (n == 1) {
		cout << n;

		return 0;
	}

	for (int i = 2; i <= n; i++)
	{
		while (n % i == 0)
		{
			n = n / i;

			cout << i;

			if (n >= i) {
				cout << " * ";
			}
		}
	}

	if (n > 1) {
		cout << n;
	}

	return 0;
}
