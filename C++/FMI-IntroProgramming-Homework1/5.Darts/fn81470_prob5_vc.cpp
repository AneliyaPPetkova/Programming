/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 5
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	float u, v, x, y;
	int R1 = 8, R2 = 3, R3 = 1;
	int R1Points = 10, R2Points = 2 * 10, R3Points = 2 * (R1Points + R2Points);
	int result;

	//Enter the Coordinates
	cin >> x >> y;
	cin >> u >> v;

	//Find the distance from O to X and Y
	float XDistanceFromO = abs(x + u);
	float YDistanceFromO = abs(y + v);
	float RDistance = sqrt(XDistanceFromO*XDistanceFromO + YDistanceFromO*YDistanceFromO);

	//Give points if (x,y) is in R1
	if (RDistance < R1 && RDistance > R2)
	{
		result = R1Points;
	}
	//Give points if (x,y) is in R2
	else if (RDistance < R2 && RDistance > R3)
	{
		result = R2Points;
	}
	//Give points if (x,y) is in R3
	else if (RDistance >= 0 && RDistance < R3)
	{
		result = R3Points;
	}
	//Give zero points if (x,y) is outside the board or on the border between two sections(between R1 and R2 or between R2 and R3)
	else
	{
		result = 0;
	}

	cout << result << endl;

	return 0;
}