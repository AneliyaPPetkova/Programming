#include<iostream>
using namespace std;

bool pDividesTo4Or7(int p);

int main()
{
	int p;
	cout << "a)Find if the integer number p divides to 4 and 7: " << endl;
	cout << "Enter p = ";
	cin >> p;
	cout << "Result: " << boolalpha << pDividesTo4Or7(p) << endl << "\n";

	return 0;
}

//Find if the integer number p divides to 4 and 7
bool pDividesTo4Or7(int p)
{
	bool result;

	result = ((p % 4) == 0 || (p % 7) == 0);

	return result;
}