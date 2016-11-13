/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 4
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	string result, attackingPiece, 
		xCoordinateOfAttackingPiece, 
		xCoordinateOfKing;
	int yCoordinateOfAttackingPiece, yCoordinateOfKing;

	string xCoordinates = "abcdefgh";

	//Enter data
	cin >> attackingPiece;
	cin >> xCoordinateOfAttackingPiece >> yCoordinateOfAttackingPiece;
	cin >> xCoordinateOfKing >> yCoordinateOfKing;
	
	int xCoordKingIndex = xCoordinates.find(xCoordinateOfKing);
	int xCoordAttackingPieceIndex = xCoordinates.find(xCoordinateOfAttackingPiece);
	int xDistanceFromAttackingPiecetoKing = abs(xCoordAttackingPieceIndex - xCoordKingIndex);
	int yDistanceFromAttackingPiecetoKing = abs(yCoordinateOfAttackingPiece - yCoordinateOfKing);
	bool isYCoordOnDist2 = ((yCoordinateOfKing == yCoordinateOfAttackingPiece - 2) || (yCoordinateOfKing == yCoordinateOfAttackingPiece + 2));
	bool isYCoordOnDist1 = ((yCoordinateOfKing == yCoordinateOfAttackingPiece - 1) || (yCoordinateOfKing == yCoordinateOfAttackingPiece + 1));

	//If attackingPiece = Rook
	if (attackingPiece == "R" && (xCoordinateOfAttackingPiece == xCoordinateOfKing || yCoordinateOfAttackingPiece == yCoordinateOfKing))
	{
		result = "Yes";
	}
	//If attackingPiece = Bishop
	else if (attackingPiece == "B" && (xDistanceFromAttackingPiecetoKing == yDistanceFromAttackingPiecetoKing))
	{
		result = "Yes";
	}
	//If attackingPiece = Queen	
	else if (attackingPiece == "Q" && (xCoordinateOfAttackingPiece == xCoordinateOfKing ||
		yCoordinateOfAttackingPiece == yCoordinateOfKing ||
		xDistanceFromAttackingPiecetoKing == yDistanceFromAttackingPiecetoKing))
	{
		result = "Yes";
	}
	//If attackingPiece = Knight
	else if (attackingPiece == "N" && (
		((xCoordKingIndex == xCoordAttackingPieceIndex + 1) && isYCoordOnDist2) ||
		((xCoordKingIndex == xCoordAttackingPieceIndex - 1) && isYCoordOnDist2) ||
		((xCoordKingIndex == xCoordAttackingPieceIndex + 2) && isYCoordOnDist1) ||
		((xCoordKingIndex == xCoordAttackingPieceIndex - 2) && isYCoordOnDist1)))
	{
		result = "Yes";
	}
	else
	{
		result = "No";
	}

	cout << result << endl;

	return 0;
}