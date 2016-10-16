#include<iostream>
using namespace std;

int main()
{
	int n;
	float temp, S = 0.0, A;

	cout << "Enter numbers count: ";
	cin >> n;

	for (int i = 1; i <= n; i++)
	{
		cout << "Enter number " << i << ": ";
		cin >> temp;

		S += temp;
	}

	A = S / n;
	cout << "The Average Sum of these " << n << " numbers is " << A << endl;

	return 0;
}