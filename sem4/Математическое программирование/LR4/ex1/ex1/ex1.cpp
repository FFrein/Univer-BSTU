#include <string>
#include <iostream>
#include <Windows.h>


using namespace std;

string generate(int amountSymb) {
	srand(time(NULL));
	string str = "\nСтрока состоит из "+ to_string(amountSymb)+" сиволов";
	char symb;
	str += "\nСтрока: ";

	for (int i = 0; i < amountSymb; i++) {
		symb = 'a' + rand()%26;
		str += symb;
	}
	return str;
}


int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	string s1 = generate(200);

	string s2 = generate(300);

	cout << s1;
	cout << s2;
}