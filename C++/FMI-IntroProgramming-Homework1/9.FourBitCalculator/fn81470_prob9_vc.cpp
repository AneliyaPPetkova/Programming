/**
*
* Solution to homework task
* Introduction to programming course
* Faculty of Mathematics and Informatics of Sofia University
* Winter semester 2016/2017
*
* @author Aneliya Petkova
* @idnumber 81470
* @task 9
* @compiler VC
*
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	int firstNumber, secondNumber;
	string operation;
	int result = 0;
	string resultAsString;

	//Enter <number> <operator> <number>
	cin >> firstNumber >> operation >> secondNumber;

	//Calculate the result of the operation
	if (operation == "+")
	{
		result = firstNumber + secondNumber;
	}
	else if (operation == "-")
	{
		result = firstNumber - secondNumber;
	}
	else if (operation == ".")
	{
		result = firstNumber*secondNumber;
	}
	else if (operation == "/")
	{
		if (secondNumber == 0)
		{
			resultAsString = "Division by zero!";
		}
		else
		{
			result = firstNumber / secondNumber;
		}
	}
	else if (operation == "%")
	{
		if (secondNumber == 0)
		{
			resultAsString = "Division by zero!";
		}
		else
		{
			result = firstNumber % secondNumber;
		}
	}

	//Take into consideration the overflow
	if (result >= 16 || result <= -16)
	{
		result = result % 16;
	}
	
	if (result < 0 && result > -16)
	{
		result = result + 16;
	}

	if (resultAsString == "")
	{
		resultAsString = to_string(result);
	}

	//Result:
	cout << resultAsString << endl;

	return 0;
}