#include<iostream>
using namespace std;

bool pDividesTo4Or7(int p);
bool theQuadraticEquationHasNoRoots(float a, float b, float c);

int main()
{
	//a)Find if the integer number p divides to 4 and 7
	int p;
	cout << "a)Find if the integer number p divides to 4 and 7: " << endl;
	cout << "Enter p = ";
	cin >> p;
	cout << "Result: " << boolalpha << pDividesTo4Or7(p) << endl << "\n";

	//b)Find if a quadratic equation has no roots
	float a, b, c;
	cout << "b)The quadratic equation has no roots: " << endl;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = ";
	cin >> c;
	cout << "Result: " << boolalpha << theQuadraticEquationHasNoRoots(a, b, c) << endl << "\n";

	return 0;
}

//a)Find if the integer number p divides to 4 and 7
bool pDividesTo4Or7(int p)
{
	bool result;

	result = ((p % 4) == 0 || (p % 7) == 0);

	return result;
}

//b)Find if a quadratic equation has no roots
bool theQuadraticEquationHasNoRoots(float a, float b, float c)
{
	bool result;
	float D;

	D = b*b - 4 * a*c;

	if (D >= 0)
	{
		result = false;
	}
	else
	{
		result = true;
	}

	return result;
}