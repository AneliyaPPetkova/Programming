#include<iostream>
using namespace std;

int main()
{
	float a, b, c, ha, S, p;

	cout << "Find the area of a triangle if the side a and height h are known:" << endl;
	cout << "a = ";
	cin >> a;
	cout << "h = ";
	cin >> ha;

	S = abs((a * ha) / 2);

	cout << "The Area of a triangle with side a = " << a << " and h = " << ha << " is " << S << endl;

	cout << "Find the area of a triangle if the three sides are known:" << endl;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = ";
	cin >> c;

	p = (a + b + c) / 2;
	S = sqrt(abs(p*(p - a)*(p - b) * (p - c)));
	cout << "The Area of a triangle with side a = " << a << ", side b = " << b << " and side c = " << c << " is " << S << endl;

	return 0;
}