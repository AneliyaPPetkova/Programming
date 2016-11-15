/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 10
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	float x, y, A, B, C, D, E, F, 
		xNominator,
		yNominator,
		determinant;
	string result;

	cin >> A >> B >> C;
	cin >> D >> E >> F;

	//I will use determinants and Cramer's rule to solve the system
	// Ax + By = C
	// Dx + Ey = F
	xNominator = (C*E - B*F);
	yNominator = (A*F - C*D);
	determinant = (A*E - B*D);

	//If nominators are 0 and denominators are 0, then the system has Many solutions
	if ((trunc(xNominator) == 0 || trunc(yNominator) == 0) && trunc(determinant) == 0)
	{
		result = "Many solutions";
		cout << result << endl;
	}
	//If denominators are 0, but nominators are different than 0, then the system has No solution
	else if (trunc(determinant) == 0)
	{
		result = "No solution";
		cout << result << endl;
	}
	//If both nominator and denominator are different than 0, then the system has a solution (x,y)
	else
	{
		x = xNominator / determinant;
		y = yNominator / determinant;

		std::cout.precision(5);
		cout << x << " " << y << endl;
	}

	return 0;
}