/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 7
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	int radiusWholeCircle = 6, radiusSmallCircle = 1, radiusBiggerCircle = 3;
	float x, y, distFromO1ToPoint, distFromO2ToPoint, distFromO3ToPoint;
	string result;

	//Enter the coordinates of point (x,y)
	cin >> x >> y;
	
	//Calculate the distance from the center of the whole circle to point (x,y)
	distFromO1ToPoint = sqrt(x*x + y*y);

	//Calculate the distance from the center of the top small circle to point (x,y)
	distFromO2ToPoint = sqrt(x*x + abs(y - 3)*abs(y - 3));

	//Calculate the distance from the center of the bottom small circle to point (x,y)
	distFromO3ToPoint = sqrt(x*x + abs(y + 3)*abs(y + 3));

	//If the point is in black part of Yin Yang return "Evil"
	if (distFromO1ToPoint < radiusWholeCircle && 
		(distFromO2ToPoint < radiusSmallCircle || 
			(x > 0 && distFromO2ToPoint > radiusBiggerCircle && distFromO3ToPoint > radiusSmallCircle) ||
			(x < 0 && distFromO3ToPoint > radiusSmallCircle && distFromO3ToPoint < radiusBiggerCircle)))
	{
		result = "Evil";
	}
	//If the point is in white part of Yin Yang return "Good"
	else if (distFromO1ToPoint < radiusWholeCircle &&
		(distFromO3ToPoint < radiusSmallCircle ||
		(x < 0 && distFromO3ToPoint > radiusBiggerCircle && distFromO2ToPoint > radiusSmallCircle) ||
		(x > 0 && distFromO2ToPoint > radiusSmallCircle && distFromO2ToPoint < radiusBiggerCircle)))
	{
		result = "Good";
	}
	//If the point is outside the whole Yin Yang circle or on a border between black and white, return "Neutral"
	else
	{
		result = "Neutral";
	}

	cout << result << endl;

	return 0;
}