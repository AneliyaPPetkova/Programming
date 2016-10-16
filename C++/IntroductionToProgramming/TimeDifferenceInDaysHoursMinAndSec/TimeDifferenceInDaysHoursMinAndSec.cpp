#include<iostream>
using namespace std;

int main()
{
	unsigned int years, daysCount, hoursCount, minutesCount, secondsCount;
	const int daysInYear = 365;
	const int hoursInDay = 24;
	const int minutesInHour = 60;
	const int secondsInMinute = 60;

	cout << "How old are you?" << endl;
	cin >> years;

	daysCount = years * daysInYear;
	hoursCount = years * daysInYear * hoursInDay;
	minutesCount = years * daysInYear * hoursInDay * minutesInHour;
	secondsCount = years * daysInYear * hoursInDay * minutesInHour * secondsInMinute;

	cout << "You have lived " << daysCount << " days or " << hoursCount << " hours or " << minutesCount << " minutes or " << secondsCount << " seconds." << endl;

	return 0;
}