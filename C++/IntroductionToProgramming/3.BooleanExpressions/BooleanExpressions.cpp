#include<iostream>
using namespace std;

bool pDividesTo4Or7(int p);
bool theQuadraticEquationHasNoRoots(float a, float b, float c);
bool isThePointInsideTheCircle(float a, float b, float c, float d, float r);

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

	//b)Find if a quadratic equation has no roots
	float aXCoord, bYCoord, circleXCoord, circleYCoord, radius;
	cout << "c)Find if a point A with coordinates(a,b) is inside the circle with center O(c,d) and radius r: " << endl;
	cout << "a = ";
	cin >> aXCoord;
	cout << "b = ";
	cin >> bYCoord;
	cout << "c = ";
	cin >> circleXCoord;
	cout << "d = ";
	cin >> circleYCoord;
	cout << "r = ";
	cin >> radius;
	cout << "Result: " << boolalpha << isThePointInsideTheCircle(aXCoord, bYCoord, circleXCoord, circleYCoord, radius) << endl << "\n";

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

//c)Find if a point A with coordinates(a,b) is inside the circle with center O(c,d) and radius r.
bool isThePointInsideTheCircle(float a, float b, float c, float d, float r)
{
	bool result;
	float distFromOtoA;

	distFromOtoA = sqrt((a - c)*(a - c) + (b - d)*(b - d));

	if (distFromOtoA <= r)
	{
		result = true;
	}
	else
	{
		result = false;
	}

	return result;
}