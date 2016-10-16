#include<iostream>
using namespace std;

int main()
{
	float a, b, c , maxNum;

	cout << "Enter three numbers: " << endl;
	cin >> a >> b >> c;

	if (a >= b && a >= c)
	{
		maxNum = a;
	}
	else if (b >= a && b >= c)
	{
		maxNum = b;
	}
	else
	{
		maxNum = c;
	}

	cout << "The biggest number is " << maxNum << endl;

	return 0;
}