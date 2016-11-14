/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 8
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	unsigned int fiftyLevaBanknote = 50,
		twentyLevaBanknote = 20,
		tenLevaBanknote = 10,
		fiveLevaBanknote = 5,
		twoLevaBanknote = 2,
		oneLevaBanknote = 1,
		ammount,
		remainder,
		fiftyLevaCount, 
		twentyLevaCount, 
		tenLevaCount, 
		fiveLevaCount, 
		twoLevaCount, 
		oneLevaCount;

	//Enter ammount of money
	cin >> ammount;

	//Construct first part of the string
	string resultFirstPart = to_string(ammount) + " =";
	string resultSecondPart = "";

	//Calculate the ammount of each banknote
	fiftyLevaCount = ammount / fiftyLevaBanknote;
	remainder = ammount % fiftyLevaBanknote;

	twentyLevaCount = remainder / twentyLevaBanknote;
	remainder = remainder % twentyLevaBanknote;

	tenLevaCount = remainder / tenLevaBanknote;
	remainder = remainder % tenLevaBanknote;

	fiveLevaCount = remainder / fiveLevaBanknote;
	remainder = remainder % fiveLevaBanknote;

	twoLevaCount = remainder / twoLevaBanknote;
	remainder = remainder % twoLevaBanknote;

	oneLevaCount = remainder / oneLevaBanknote;
	remainder = remainder % oneLevaBanknote;

	//Construct second part of the string
	if (fiftyLevaCount != 0)
	{
		resultSecondPart += " " + to_string(fiftyLevaCount) + "*" + to_string(fiftyLevaBanknote) + " +";
	}
	if (twentyLevaCount != 0)
	{
		resultSecondPart += " " + to_string(twentyLevaCount) + "*" + to_string(twentyLevaBanknote) + " +";
	}
	if (tenLevaCount != 0)
	{
		resultSecondPart += " " + to_string(tenLevaCount) + "*" + to_string(tenLevaBanknote) + " +";
	}
	if (fiveLevaCount != 0)
	{
		resultSecondPart += " " + to_string(fiveLevaCount) + "*" + to_string(fiveLevaBanknote) + " +";
	}
	if (twoLevaCount != 0)
	{
		resultSecondPart += " " + to_string(twoLevaCount) + "*" + to_string(twoLevaBanknote) + " +";
	}
	if (oneLevaCount != 0)
	{
		resultSecondPart += " " + to_string(oneLevaCount) + "*" + to_string(oneLevaBanknote) + " +";
	}

	//Remove the last plus symbol
	int indexOfLastPlus = resultSecondPart.find_last_of("+");
	if (indexOfLastPlus == resultSecondPart.length() - 1)
	{
		resultSecondPart.erase(indexOfLastPlus - 1, indexOfLastPlus);
	}

	//Result:
	cout << resultFirstPart + resultSecondPart << endl;
	
	return 0;
}