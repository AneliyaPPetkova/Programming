/**
*
* Introduction to programming course
* Winter semester 2024/2025
* Faculty of Mathematics and Informatics of Sofia University
* @author Aneliya Petkova
* @FN 0MI0700322
*
* Homework 1
* Task 1: Triangle
* 
* Write a program that, given the coordinates of 3 points (A, B, and C), 
* each with coordinates x and y, which form the triangle ABC, 
* and the coordinates x and y of a fourth point D, 
* determines whether point D lies inside the triangle or outside it. 
* If point D lies inside the triangle, the program should output the message "In"; 
* otherwise, it should output the message "Out".
* 
*/

#include <iostream>
#include <cmath>
using namespace std;

double getTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3);
double getDistanceBetweenPoints(int x1, int y1, int x2, int y2);

int main()
{
	double 
		pointAx, pointAy, 
		pointBx, pointBy, 
		pointCx, pointCy, 
		pointDx, pointDy;
	string result;

	//Enter the coordinates of point A (x,y)
	cout << "A (x y): ";
	cin >> pointAx >> pointAy;

	//Enter the coordinates of point B (x,y)
	cout << "B (x y): ";
	cin >> pointBx >> pointBy;

	//Enter the coordinates of point C (x,y)
	cout << "C (x y): ";
	cin >> pointCx >> pointCy;

	//Enter the coordinates of point D (x,y)
	cout << "D (x y): ";
	cin >> pointDx >> pointDy;

	// Calculate the areas
	double areaABC = getTriangleArea(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);

	double areaABD = getTriangleArea(pointAx, pointAy, pointBx, pointBy, pointDx, pointDy);
	double areaBCD = getTriangleArea(pointBx, pointBy, pointCx, pointCy, pointDx, pointDy);
	double areaCAD = getTriangleArea(pointCx, pointCy, pointAx, pointAy, pointDx, pointDy);

	double areasSum = areaABD + areaBCD + areaCAD;

	// If point D lies inside the triangle, return "In"
	if (fabs(areaABC - areasSum) < 0.1) {
		result = "In";
	}
	else { // If point D lies outside the triangle, return "Out"
		result = "Out";
	}

	cout << result << endl;

	return 0;
}

// Function for calculating triangle area
double getTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
{
	double side1 = getDistanceBetweenPoints(x1, y1, x2, y2);
	double side2 = getDistanceBetweenPoints(x2, y2, x3, y3);
	double side3 = getDistanceBetweenPoints(x1, y1, x3, y3);

	if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1) {
		std::cout << "The points do not form a valid triangle." << std::endl;
		return 1;
	}

	double perimeter = side1 + side2 + side3;

	double semiPerimeter = perimeter / 2;

	double area = sqrt(semiPerimeter *
		(semiPerimeter - side1) *
		(semiPerimeter - side2) *
		(semiPerimeter - side3));

	return area;
}

// Function for calculating distance between two points
double getDistanceBetweenPoints(int x1, int y1, int x2, int y2) {
	return sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
}