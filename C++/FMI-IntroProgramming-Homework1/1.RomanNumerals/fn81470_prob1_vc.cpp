/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 1
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

string naturalNumberToRomanNumeral(int a);

int main()
{
	int number;

	//Enter number
	cin >> number;

	if (number <= 0 || number > 3000)
	{
		//Result
		cout << "Invalid number!" << endl;
	}
	else
	{
		//Convert the natural number to Roman numeral
		string romanNumeral = naturalNumberToRomanNumeral(number);

		//Result
		cout << romanNumeral << endl;
	}

	return 0;
}

//Function for converting whole positive number from 1 to 3000 to roman numeral
string naturalNumberToRomanNumeral(int number)
{
	string romanNumeral;

	//Numbers from 1 to 9
	string units[] = { "","I","II","III","IV","V","VI","VII","VIII","IX" };

	//Numbers from 10 to 90
	string tens[] = { "","X","XX","XXX","XL","L","LX","LXX","LXXX","XC" };

	//Numbers from 100 to 900
	string hundreds[] = { "","C","CC","CCC","CD","D","DC","DCC","DCCC","CM" };

	//M=1000, MM=2000, MMM=3000
	string thousands[] = { "","M","MM","MMM" };

	/*Construct a string which represents the roman numeral of the number, 
	by separating the number into Thousands, Hundreds, Tens and Units 
	and then using the roman numeral from the corresponding array */
	romanNumeral = thousands[number / 1000] + hundreds[(number % 1000) / 100] + tens[(number % 100) / 10] + units[(number % 10)];

	return romanNumeral;
}