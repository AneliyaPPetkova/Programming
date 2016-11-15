/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 3
* @compiler VC
*
*/

#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main()
{
	unsigned int number;
	string result;

	//Enter number
	cin >> number;

	//Convert the number to hexadecimal numeral system
	stringstream sstream;
	sstream << std::hex << number;
	string hexNumber = sstream.str();

	//Find if there is different than the first character in the string. 
	//Returns -1 if all characters are the same and != -1 number if there is a different character.
	int diffCharacterPos = hexNumber.find_first_not_of(hexNumber[0]);

	//Find result
	if (diffCharacterPos != -1)
	{
		result = "No";
	}
	else
	{
		result = "Yes";
	}

	cout << result << endl;

	return 0;
}