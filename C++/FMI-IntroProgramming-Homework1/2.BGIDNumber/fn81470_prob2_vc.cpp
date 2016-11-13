/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 2
* @compiler VC
*
*/

#include <iostream>
#include <string>
#include <sstream>
using namespace std;

//Method for converting string literal to integer
int stringToInteger(string numberAsString)
{
	int numberAsInteger;
	stringstream ss;
	ss << numberAsString;
	ss >> numberAsInteger;
	return numberAsInteger;
}

//Method for checking if the year is leap. Returns 1 if true and 0 if false.
int isLeapYear(int year)
{
	bool result = 0;

	if (year % 4 == 0)
	{
		if (year % 100 == 0)
		{
			if (year % 400 == 0)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		else
		{
			result = 1;
		}
	}
	else
	{
		result = 0;
	}

	return result;
}

int main()
{
	string idNumber, result, yearOfBirth, monthOfBirth, gender;
	
	//Enter Id number
	cin >> idNumber;

	if (idNumber.length() != 10)
	{
		result = "Bad input data!";
	}
	else
	{
		//Get the day
		string day = idNumber.substr(4, 2);
		int dayToInt = stringToInteger(day);

		//Get the month
		string month = idNumber.substr(2, 2);
		int monthToInt = stringToInteger(month);

		//Get the year
		string year = idNumber.substr(0, 2);
		int yearToInt = stringToInteger(year);

		//Get the gender
		string ninthNumber = idNumber.substr(8, 1);
		int genderToInt = stringToInteger(ninthNumber);

		//Years from 1900 to 1999
		if (monthToInt >= 1 && monthToInt <= 12)
		{
			yearOfBirth = "19" + year;
			monthOfBirth = month;
		}
		//Years < 1900
		else if (monthToInt >= 21 && monthToInt <= 32)
		{
			yearOfBirth = "18" + year;
			monthToInt = monthToInt - 20;
			monthOfBirth = to_string(monthToInt);
		}
		//Years >= 2000
		else if (monthToInt >= 41 && monthToInt <= 52)
		{
			yearOfBirth = "20" + year;
			monthToInt = monthToInt - 40;
			monthOfBirth = to_string(monthToInt);
		}
		else
		{
			result = "Bad input data!";
		}

		if (yearOfBirth != "")
		{
			//Days in every month in the Gregorian calendar. Leap years are taken into account.
			int daysInMonth[] = { 31,(28 + isLeapYear(stringToInteger(yearOfBirth))),31,30,31,30,31,31,30,31,30,31 };

			//Check if the entered day is in the month.
			if (dayToInt < 1 || dayToInt > daysInMonth[stringToInteger(monthOfBirth) - 1])
			{
				result = "Bad input data!";
			}
		}

		//Get gender via the ninth number in the Id.
		if (genderToInt % 2 == 0)
		{
			gender = "M";
		}
		else
		{
			gender = "F";
		}

		if (result != "Bad input data!")
		{
			if (monthOfBirth.length() < 2)
			{
				monthOfBirth = "0" + monthOfBirth;
			}

			//Construct the result string
			result = day + "." + monthOfBirth + "." + yearOfBirth + " " + gender;
		}

	}

	std::cout << result << endl;

	return 0;
}