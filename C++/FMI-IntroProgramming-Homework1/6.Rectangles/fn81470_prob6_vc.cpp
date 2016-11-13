/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 6
* @compiler VC
*
*/

#include <iostream>
using namespace std;

int main()
{
	int x1, y1, h1, w1;
	int x2, y2, h2, w2;
	int aSide, bSide, area;

	//Enter (x1,y1) of the bottom left point and height h1 and width w1 of the first rectangle
	cin >> x1 >> y1 >> h1 >> w1;
	//Enter (x2,y2) of the bottom left point and height h2 and width w2 of the second rectangle
	cin >> x2 >> y2 >> h2 >> w2;

	//Get side a of the new rectangle if there is an intersection between both rectangles
	if (x1 > x2 && x1 < x2 + w2)
	{
		aSide = w2 - (x1 - x2);
	}
	else if (x2 > x1 && x2 < x1 + w1)
	{
		aSide = w1 - (x2 - x1);
	}
	else
	{
		aSide = 0;
	}

	//Get side b of the new rectangle if there is an intersection between both rectangles
	if (y1 > y2 && y1 < y2 + h2)
	{
		bSide = h2 - (y1 - y2);
	}
	else if (y2 > y1 && y2 < y1 + h1)
	{
		bSide = h1 - (y2 - y1);
	}
	else
	{
		bSide = 0;
	}

	//Calculate the area of the intersection of both rectangles
	area = aSide*bSide;

	cout << area << endl;

	return 0;
}