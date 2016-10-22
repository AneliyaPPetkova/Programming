#include<iostream>
using namespace std;

bool pDividesTo4Or7(int p);
bool theQuadraticEquationHasNoRoots(float a, float b, float c);
bool isThePointInsideTheCircle(float a, float b, float c, float d, float r);
bool isThePointInsideThirdQuadrantAndInTheCircle(float a, float b);

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

	//c)Find if a point A with coordinates(a,b) is inside the circle with center O(c,d) and radius r:
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

	//d)Find if a point belongs to the third quadrant of a circle with center (0,0) and radius 5.
	float firstCoord, secondCoord;
	cout << "d)Find if a point belongs to the third quadrant of a circle with center (0,0) and radius 5: " << endl;
	cout << "a = ";
	cin >> firstCoord;
	cout << "b = ";
	cin >> secondCoord;
	cout << "Result: " << boolalpha << isThePointInsideThirdQuadrantAndInTheCircle(firstCoord, secondCoord) << endl << "\n";
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

//d)Find if a point belongs to the third quadrant of a circle with center (0,0) and radius 5.
bool isThePointInsideThirdQuadrantAndInTheCircle(float a, float b)
{
	bool result;
	float distFromOtoA;
	int r = 5;

	distFromOtoA = sqrt(a*a + b*b);

	if (a < 0 && b < 0 && distFromOtoA <= r)
	{
		result = true;
	}
	else
	{
		result = false;
	}

	return result;
}